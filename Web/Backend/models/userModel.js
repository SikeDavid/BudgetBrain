import db from '../database.js';

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
// updateUserStatus()
// reset password
// delete user

export {
    findUserByUsernamePassword,
    findUserByUsernameEmail,
    createUser
};