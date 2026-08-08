import db from "../database.js";

export async function modelAdminUsersGet () {
    const sql = `
        SELECT user_id, username, email, user_status, role FROM users;
    `;

    const [result] = await db.query(sql);

    return result;
}

export async function modelAdminUserStatus (userId, userStatus) {
    const sql = `
        UPDATE users
        SET user_status = ?
        WHERE user_id = ?
    `;

    const [result] = await db.query(sql, [userStatus, userId])

    return result;
}

export async function modelAdminUserPassword (userId, password) {
    const sql = `
        UPDATE users
        SET password = ?
        WHERE user_id = ?
    `;

    const [result] = await db.query(sql, [password, userId]);

    return result;
}

export async function modelAdminUserDelete (userId) {
    const sql = `
        DELETE FROM users
        WHERE user_id = ?
    `;

    const [result] = await db.query(sql, [userId]);
    
    return result;
}