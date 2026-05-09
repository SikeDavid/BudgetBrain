import {
    findUserByUsernamePassword,
    findUserByUsernameEmail,
    createUser    
} from '../models/userModel.js';

async function login(req, res) {
    const {username, password} = req.body;

    if (!username || !password) {
        return res.status(400).json({
            message: "Missing data"
        });
    }

    try {
        const user = await findUserByUsernamePassword(username, password);

        if(!user) {
            return res.status(401).json({
                message: "Username or Password not match"
            });
        }

        switch (user.user_status) {
            case "active":
                return res.status(200).json({user});
                break
            case "pending":
                return res.status(403).json({
                    message: "User is not yet activated"
                });
                break
            case "suspended":
                return res.status(403).json({
                    message: "Invalid user status"
                });
        }
    }
    catch (err)
    {
        console.error("Server error", err);

        return res.status(500).json({
            message: "Server error"
        });
    }
}

async function registration(req, res) {
    const {username, password, email} = req.body;

    if(!username || !password || !email) {
        return res.status(400).json({
            message: "Missing data"
        });
    }

    try {
        const existingUser = await findUserByUsernameEmail(username, email);

        if (existingUser) {
            return res.status(409).json({
                message: "Username or Email already in use"
            });
        }

        const userId = await createUser(username, password, email);

        return res.status(201).json({
            message: "Registration successful",
            userId
        });
    }
    catch (err) {
        console.error("Server error", err);

        return res.status(500).json({
            message: "Server error"
        });
    }
}

export {
    login,
    registration
};