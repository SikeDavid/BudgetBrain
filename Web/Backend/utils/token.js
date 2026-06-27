import db from '../database.js';
import jwt from 'jsonwebtoken';

export function createAccessToken(user) {
    return jwt.sign(
        {
            userId: user.user_id,
            username: user.username
        },
        process.env.ACCESS_TOKEN_SECRET,
        { expiresIn: process.env.ACCESS_TOKEN_EXPIRES || "15m" }
    );
}

export function createRefreshToken(user) {
    return jwt.sign(
        {
            userId: user.user_id
        },
        process.env.REFRESH_TOKEN_SECRET,
        { expiresIn: process.env.REFRESH_TOKEN_EXPIRES || "7d" }
    );
}

export async function saveRefreshToken(userId, refreshToken) {
    const sql = `
        INSERT INTO refresh_token (user_id, token)
        VALUES (?, ?)
    `;

    const [result] = await db.query(sql, [userId, refreshToken]);
    return result;
}

export async function findRefreshToken(refreshToken) {
    const sql = `
        SELECT *
        FROM refresh_token
        WHERE token = ?
    `;

    const [rows] = await db.query(sql, [refreshToken]);
    return rows[0];
}

export async function deleteRefreshToken(refreshToken) {
    const sql = `
        DELETE FROM refresh_token
        WHERE token = ?
    `;

    const [result] = await db.query(sql, [refreshToken]);
    return result;
}