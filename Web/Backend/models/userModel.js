import db from '../database.js';

async function findById(userId) {
    const sql = `
        SELECT user_id, username, user_status
        FROM users
        WHERE user_id = ?
    `;

    const [rows] = await db.query(sql, [userId]);
    return rows[0];
}

async function findUserByUsernamePassword(username, password) {
    const sql = `
        SELECT
            user_id,
            username,
            user_status
        FROM users
        WHERE username = ?
        AND password = ?
    `;

    const [row] = await db.query(sql, [username, password]);

    return row[0];
}

// createUser()
async function findUserByUsernameEmail(username, email) {
    const sql = `
        SELECT
            username,
            email
        FROM users
        WHERE username=?
        OR email=?
    `;

    const [row] = await db.query(sql, [username, email]);

    return row[0];
}

async function createUser(username, password, email) {
    const sql = `
        INSERT INTO users
            (username, password, email)
        VALUES (?, ?, ?)
    `;

    const [result] = await db.query(sql, [username, password, email]);

    return result.insertId;
}

// Tokens
async function saveRefreshToken(userId, refreshToken) {
    const sql = `
        INSERT INTO refresh_token (user_id, token)
        VALUES (?, ?)
    `;

    const [result] = await db.query(sql, [userId, refreshToken]);
    return result;
}

async function findRefreshToken(refreshToken) {
    const sql = `
        SELECT *
        FROM refresh_token
        WHERE token = ?
    `;

    const [rows] = await db.query(sql, [refreshToken]);
    return rows[0];
}

async function deleteRefreshToken(refreshToken) {
    const sql = `
        DELETE FROM refresh_token
        WHERE token = ?
    `;

    const [result] = await db.query(sql, [refreshToken]);
    return result;
}
// updateUserStatus()
// reset password
// delete user

export {
    findById,
    findUserByUsernamePassword,
    findUserByUsernameEmail,
    createUser,
    saveRefreshToken,
    findRefreshToken,
    deleteRefreshToken
};