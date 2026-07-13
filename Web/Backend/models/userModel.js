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

export async function findUserByUsername(username) {
    const sql = `
        SELECT
            user_id,
            username,
            password,
            user_status,
            role
        FROM users
        WHERE username = ?
    `;

    const [row] = await db.query(sql, [username]);

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

export async function modelUserRegistration (username, password, email) {
    const connection = await db.getConnection();

    try {
        await connection.beginTransaction();
        // 1. User létrehozása
        const userSql = `
            INSERT INTO users
                (username, password, email)
            VALUES (?, ?, ?)
        `;

        const [userResult] = await connection.query(userSql, [username, password, email]);
        const userid = userResult.insertId;
        // 2. Két alap kategória létrehozása
        const categorySql = `
            INSERT INTO categories
                (user_id, name, type)
            VALUES (?, ?, ?), (?, ?, ?)
        `;

        await connection.query(categorySql,[
            userid, "Egyéb bevétel", "income",
            userid, "Egyéb kiadás", "expense"
        ]);
        // 3. Minden sikerült
        await connection.commit();

        return userid;
    }
    catch (err) {
        // Bármi hiba történt
        // Minden módosítás visszavonása
        await connection.rollback();
        throw err;
    }
    finally {
        // connection visszakerül a poolba
        connection.release();
    }
}

// Tokens

// updateUserStatus()
// reset password
// delete user
