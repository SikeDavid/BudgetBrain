import express, { json } from 'express';
import dotenv from 'dotenv';
import cors from 'cors';

import db from './database.js';
import { databaseTest } from './database.js';

dotenv.config();
const app = express();
const port = process.env.PORT;

app.use(cors());
app.use(express.json())

// ====================
// logger
// ====================
app.use((req, res, next) => {
    console.log(`${new Date().toISOString()}`);
    console.log(`\t${req.method} ${req.path}`);
    if(req.body) {
        console.log(`\tbody: ${JSON.stringify(req.body)}`);
    };
    next();
});

// ====================
// public routes
// ====================

app.get('/', (req, res) => {
    res.status(200).send('Backend server running...');
});

// Login
app.post('/api/public/login', async(req, res) => {
    const { username, password } = req.body;

    if(!username || !password) {
        return res.status(400).json({message: "Missing data"});
    }
    try {
        const sql = "SELECT user_id, username, user_status FROM users WHERE username=? and password=?";
        const [row] = await db.query(sql, [username, password]);

        if(!row || row.length === 0) {
            return res.status(401).json({message: "Username or Password not match"});
        };

        const user = row[0];
        switch(user.user_status) {
            case "active":
                return res.status(200).json({user});
                break
            case "pending":
                return res.status(403).json({message: "User is not yet activated"});
                break
            case "suspended":
                return res.status(403).json({message: "User is suspended"});
                break
        }
    }
    catch (err) {
        console.error("Database error", err);
        return res.status(500).json({message: "Database error"});
    };

});

// Registration
app.post('/api/public/registration', async(req, res) => {
    const { username, password, email } = req.body;

    if(!username || !password || !email) {
        return res.status(400).json({message: "Missing data"});
    }
    try {
        const sql = "SELECT * FROM users where username=? or email=?";
        const [row] = await db.query(sql, [username, email]);
        if(row.length > 0) {
            return res.status(409).json({message: "Username or Email already registrated"});
        };
        const registration = "INSERT INTO users (username, password, email) VALUES (?, ?, ?)";
        const [result] = await db.query(registration, [username, password, email]);
        return res.status(201).json({message: "Successful registration", userid: result.insertId});
    }
    catch (err) {
        console.error("Registration failed", err);
        return res.status(500).json({message: "Server error"});
    }
    
});

// reset password
app.post('/api/public/password-reset-request', async(req, res) => {
    const { username, password} = req.body;

    if (!username || !password) return res.status(400).json({message: "Missing data"});

    const sql = "SELECT user_id, username, password FROM users WHERE username=? and password=?";
    const [row] = await db.query(sql, [username, password]);

    if(!row || row.length === 0) {
        return res.status(401).json({message: "Username or Password not match"});
    };

    const user = row[0];
    
    const sqlfeedback = 'INSERT INTO feedback (title, message, user_id) VALUES (?, ?, ?);'
    await db.query(sqlfeedback, ['Password reset request', `${user.username} requested a password reset`, `${user.user_id}`]);
    return res.status(201).json({message: "Password reset request sent"});
})
// delete user

// ====================
// private routes
// ====================
// authenticate middleware
app.use((req, res, next) => {
    // Here we check the token exist and valid
    req.userid = 2
    if (!req.userid) return res.status(401).json({message: "You are not loged in"});
    next();
});

// dashboard
app.get('/api/private/dashboard', async(req, res) => {
    const id = req.userid;
    const year = new Date().getFullYear();
    const month = new Date().getMonth() + 1;

    const sqlGenerateEntryPlanner = `CALL generate_entry_planner(?, ?, ?);`;
    await db.query(sqlGenerateEntryPlanner, [id, year, month]);

    const sqlBalance = `
        SELECT
            COALESCE(SUM(
                CASE
                    WHEN c.type = 'income' THEN e.amount
                    WHEN c.type = 'expense' THEN -e.amount
                END
            ), 0) AS monthly_balance,
            COALESCE(SUM(
                CASE WHEN c.type = 'income'THEN e.amount ELSE 0 END
            ), 0) AS monthly_income,
            COALESCE(SUM(
                CASE WHEN c.type = 'expense'THEN -e.amount ELSE 0 END
            ), 0) AS monthly_expense
        FROM entries e
        JOIN categories c on e.category_id =c.category_id
        WHERE e.user_id = ?
        AND YEAR(e.date) = ?
        AND MONTH(e.date) = ?;`;
    const [balance] = await db.query(sqlBalance, [id, year, month]);

    const sqlEntries = `SELECT 
                    e.entry_id,
                    CASE
	                    WHEN c.type = 'expense' THEN -e.amount
		                ELSE e.amount
	                END AS amount,
                    e.description,
                    e.date,
                    e.completed,
                    e.planned_entry_id,
                    c.name AS category_name,
                    c.type
                FROM entries e
                JOIN categories c ON e.category_id = c.category_id
                WHERE e.user_id = ?
                    AND e.completed = true
                    AND YEAR(e.date) = ?
                    AND MONTH(e.date) = ?
                ORDER BY
                    e.date DESC, e.entry_id DESC
                LIMIT 5;`;
    const [entries] = await db.query(sqlEntries, [id, year, month]);
    return res.status(200).json({
        balance: balance,
        entries: entries
        });
});

// GET /api/private/entries
// POST /api/private/entries
// PATCH /api/private/entries/:id
// DELETE /api/private/entries/:id
// PATCH /api/private/entries/:id/complete

// GET /api/private/categories
// POST /api/private/categories
// PATCH /api/private/categories/:id
// DELETE /api/private/categories/:id

// GET /api/private/planned-entries
// POST /api/private/planned-entries
// PATCH /api/private/planned-entries/:id
// DELETE /api/private/planned-entries/:id


// ====================
// admin routes
// ====================

app.listen(port, async() => {
    console.log(`Server is running on port: ${port}`);
    await databaseTest();
});


/*
Methods:
    GET (retrieve)
    POST (create/submit)
    PUT (replace)
    PATCH (update)
    DELETE (remove)
*/
/*
Status codes:
    200 OK
    201 Created
    400 Bad Request
    401 Unauthorized
    403 Forbidden
    404 Not Found
    409 Conflict
    418 I'm a Teapot
    429 Too Many Request
    500 Internal Server Error
*/