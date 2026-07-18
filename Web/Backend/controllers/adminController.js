import dotenv from 'dotenv';
import bcrypt from 'bcrypt';

import {
    modelAdminUsersGet,
    modelAdminUserStatus,
    modelAdminUserPassword,
    modelAdminUserDelete
} from '../models/adminModel.js';

export async function controllerGetUsers(req, res) {
    try {
        const result = await modelAdminUsersGet();

        return res.status(200).json(result);
    }
    catch (err) {
        console.error(err);
        return res.status(500).json({message: "Server error"});
    }
}

export async function controllerSetUserStatus(req, res) {
    const userId = req.params.id;
    const { status } = req.body;

    const statuses = ["active", "pending", "suspended"];

    if (!statuses.includes(status)) {
        return res.status(400).json({message: "Invalid user status"});
    }

    try {
        const result = await modelAdminUserStatus(userId, status)

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "User not found"});
        }

        return res.status(200).json({message: "Status successful changed"});
    }
    catch (err) {
        console.error("User status update error", err);
    }
}

export async function controllerSetUserPassword(req, res) {
    const userId = req.params.id;
    const defaultPassword = process.env.DEFAULT_USER_PASSWORD;

    try {
        const hash = await bcrypt.hash(defaultPassword, 11);

        const setPass = await modelAdminUserPassword(userId, hash);

        if (setPass.affectedRows === 0) {
            return res.status(400).json({message: "User not found"});
        }

        return res.status(200).json({message: "Password successful reseted"});
    } 
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }

}

export async function controllerUserDelete(req, res) {
    const userId = Number(req.params.id);
    console.log(req.user);

    if (req.user.id === userId) {
        return res.status(403).json({message: "You cannot delete your own account"});
    }

    if (req.user.role === "admin") {
        return res.status(403).json({message: "You cannot delete admin accounts"});
    }

    if (!Number.isInteger(userId) || userId <=0) {
        return res.status(400).json({message: "Invalid user id"});
    }

    try {
        const result = await modelAdminUserDelete(userId);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "User not found"});
        }

        return res.status(200).json({message: "User deleted successfully"});
    }
    catch (err) {
        console.error(err);
        return res.status(500).json({message: "Server error"});
    }
}