import db from '../database.js';

export async function findUserById(userId) {
    const sql = `
        SELECT user_id, username, user_status
        FROM users
        WHERE user_id = ?
    `;

    const [rows] = await db.query(sql, [userId]);
    return rows[0];
}

export async function findUserByUsernamePassword(username, password) {
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
export async function findUserByUsernameEmail(username, email) {
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

export async function createUser(username, password, email) {
    const sql = `
        INSERT INTO users
            (username, password, email)
        VALUES (?, ?, ?)
    `;

    const [result] = await db.query(sql, [username, password, email]);

    return result.insertId;
}

// Tokens

// updateUserStatus()
// reset password
// delete user
