import {
    findUserById,
    findUserByUsername,
    findUserByUsernameEmail,
    createUser,
    modelUserRegistration  
} from '../models/userModel.js';
import {
    createAccessToken,
    createRefreshToken,
    saveRefreshToken,
    findRefreshToken,
    deleteRefreshToken } from '../utils/token.js';

import jwt from 'jsonwebtoken';
import bcrypt from 'bcrypt';

export async function login(req, res) {
    if (!req.body) return res.status(404).json({
        message: "Missing body",
        requirements: "username, password"
    });

    const {username, password} = req.body;
    if (!username || !password) return res.status(400).json({message: "Missing data"});

    try {
        const user = await findUserByUsername(username);

        if(!user) return res.status(401).json({message: "Username or Password not match"});

        const validPassword = await bcrypt.compare(password, user.password);
        if (!validPassword) return res.status(401).json({message: "Username or Password not match"});

        switch (user.user_status) {
            case "active":
                const accessToken = createAccessToken(user);
                const refreshToken = createRefreshToken(user);
                await saveRefreshToken(user.user_id, refreshToken);
                return res.status(200).json({
                    user: {
                        userId: user.user_id,
                        username: user.username
                    },
                    accessToken,
                    refreshToken
                });
                break
            case "pending":
                return res.status(403).json({message: "User is not yet activated"});
                break
            case "suspended":
                return res.status(403).json({message: "Invalid user status"});
        }
    }
    catch (err)
    {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}

export async function registration(req, res) {
        if (!req.body) return res.status(404).json({
        message: "Missing body",
        requirements: "username, email, password"
    });
    const {username, password, email} = req.body;

    if(!username || !password || !email) {
        return res.status(400).json({message: "Missing data"});
    }

    const passwordRegex = /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*+-]).{8,64}$/;
    if (!passwordRegex.test(password)) return res.status(418).json({
        message: "Password -> min 8 char, Uppercase, digit, special char"
    });

    try {
        const existingUser = await findUserByUsernameEmail(username, email);

        if (existingUser) {
            return res.status(409).json({message: "Username or Email already in use"});
        }

        const hash = await bcrypt.hash(password, 11);

        // const userId = await createUser(username, hash, email);
        const userId = await modelUserRegistration(username, hash, email);

        return res.status(201).json({
            message: "Registration successful",
            userId: userId
        });
    }
    catch (err) {
        console.error("Server error", err);

        return res.status(500).json({message: "Server error"});
    }
}

export async function logout(req, res) {
    const { refreshToken} = req.body;

    if (!refreshToken) return res.status(403).json({message: "Missing refreshtoken"});

    try {
        const result = await deleteRefreshToken(refreshToken);
        return res.status(200).json({message: "Logout success"});
    } catch (err) {
        console.error("Logout error", err);
        return res.status(500).json({message: "Server error"});
    }
}

export async function refreshToken(req, res) {
    const { refreshToken } = req.body;

    if (!refreshToken) return res.status(400).json({message: "Missing refresh token"});

    try {
        const storedToken = await findRefreshToken(refreshToken);

        if (!storedToken) return res.status(403).json({message: "Refresh token not found"});

        const decoded = jwt.verify(
            refreshToken,
            process.env.REFRESH_TOKEN_SECRET
        );

        const user = await findUserById(decoded.userId);

        if (!user) return res.status(403).json({message: "User not found"});
        if (user.user_status != "active") return res.status(403).json({message: "User is not active"});

        const accessToken = createAccessToken(user);
        return res.status(201).json({accesstoken: accessToken});

    } catch (err) {
        console.error(err)
        return res.status(500).json({message: "Server error"});
    }
}
