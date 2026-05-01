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
});
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


// dashboard - Monthly balace, income, expense, last 5 entry
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

// GET /api/private/categories
app.get('/api/private/categories', async(req, res) => {
    const id = req.userid;

    const sql = ` SELECT
        c.category_id,
        c.name,
        c.type
        FROM categories c
        JOIN users u ON c.user_id = u.user_id
        WHERE c.user_id = ?
        AND c.in_use = true;`

    const [categories] = await db.query(sql, id);

    return res.status(200).json({categories});
});

// POST /api/private/categories
app.post('/api/private/categories', async(req, res) => {
    const id = req.userid;
    const {name, type} = req.body;
    const in_use = true;

    const sql = `INSERT INTO categories (user_id, name, type, in_use) VALUES (?, ?, ?, ?);`

    await db.query(sql, [id, name, type, in_use]);

    return res.status(201).json({message: "category created"});
});
// PATCH /api/private/categories/:id

// DELETE /api/private/categories/:id
app.patch('/api/private/categories/:categoryid/status', async(req, res) => {
    const id = req.userid;
    const categoryid = req.params.categoryid;
    const { status } = req.body;
    
    if (typeof status !== "boolean") return res.status(400).json({ message: "status must be boolean"});
    
    Number(status); // convert status to 1:0

    const sql = `UPDATE
        categories 
        SET in_use = ? 
        WHERE category_id = ?
        AND user_id = ?;`

    await db.query(sql, [status, categoryid, id]);

    return res.status(200).json({message: "category removed from active use"});
});

// GET /api/private/entries
app.get('/api/private/entries/:year/:month', async(req, res) => {
    const id = req.userid
    const {year, month} = req.params;

    const sql = `SELECT
        e.entry_id,
        c.name,
        e.description,
        CASE
            WHEN c.type = 'expense' THEN -e.amount
            ELSE e.amount
        END AS amount,
        e.date,
        e.completed
        
    FROM entries e
    JOIN categories c ON e.category_id = c.category_id
    WHERE e.user_id = ?
        AND YEAR(e.date) = ?
        AND MONTH(e.date) = ?;`
    const [result] = await db.query(sql, [id, year, month])
    return res.status(200).json({result})
});

// POST /api/private/entries
app.post('/api/private/entries', async(req, res) => {
    const id = req.userid;
    const {categoryid, amount, description, date} = req.body;

    const sql = `INSERT 
        INTO entries (user_id, category_id, amount, description, date, completed) VALUES 
        (?, ?, ?, ?, ?, ?);`
    await db.query(sql, [id, categoryid, amount, description, date, true]);

    return res.status(201).json({message: "entry created"});
});
// PATCH /api/private/entries/:id
app.patch('/api/private/entries/:id', async(req, res) => {
    const id = req.userid;
    const entryid = req.params.id;
    console.log(req.body)
    const {categoryid, amount, description, date, completed} = req.body;

    const sql = `UPDATE entries
        SET category_id = ?,
            amount = ?,
            description = ?,
            date = ?,
            completed = ?
        WHERE entry_id = ?
        AND user_id = ?;`;

    const [result] = await db.query(sql, [categoryid, amount, description, date, Number(completed), entryid, id]);

    if (result.affectedRows === 0) {
        return res.status(404).json({message: "Entry not found"});
    }

    return res.status(200).json({message: "entry updated"});
});

// PATCH /api/private/entries/:id/complete
app.patch('/api/private/entries/:id/complete', async(req, res) => {
    const id = req.userid;
    const entryid = req.params.id;

    const sql = `UPDATE entries
        SET completed = NOT completed
        WHERE entry_id = ?
        AND user_id = ?;`;

    const [result] = await db.query(sql, [entryid, userid]);

    if (result.affectedRows === 0) {
        return res.status(404).json({message: "entry not found"});
    }

    return res.status(200).json({message: "entry changed"});
});

// DELETE /api/private/entries/:id
app.delete('/api/private/entries/:id', async(req, res) => {
    const id = req.userid;
    const entryid = req.params.id;

    const sql = `DELETE
        FROM entries
        WHERE entry_id = ?
        AND user_id = ?;`;

    const [result] = await db.query(sql, [entryid, userid]);

    if (result.affectedRows === 0) {
        return res.status(404).json({message: "Entry not found"});
    }

    return res.status(200).json({message: "Entry deleted"});
    
});

// GET /api/private/planned-entries
app.get('/api/private/planned-entries', async(req, res) => {
    const userid = req.userid;

    const sql = ` SELECT
            c.name AS category_name,
            c.type,
            p.name AS entry_name,
            ( CASE
                WHEN c.type = 'income' THEN p.amount
                WHEN c.type = 'expense' THEN -p.amount
                END
            ) AS amount,
            p.day_of_month,
            p.active
        FROM entry_planner p
        JOIN categories c ON p.category_id = c.category_id
        WHERE
            p.user_id = ?;`;

    const [result] = await db.query(sql, userid);

    return res.status(200).json({result});
});

// POST /api/private/planned-entries
app.post('/api/private/planned-entries', async(req, res) => {
    const userid = req.userid;
    const {categoryid, name, amount, dayOfMonth} = req.body;

    const sql = `INSERT INTO entry_planner
            (user_id, category_id, name, amount, day_of_month)
        VALUES (?, ?, ?, ?, ?);`;

    await db.query(sql, [userid, categoryid, name, amount, dayOfMonth]);

    return res.status(201).json({message: "planned entry created"});
});

// PATCH /api/private/planned-entries/:id
app.patch('/api/private/planned-entries/:id', async(req, res) => {
    const userid = req.userid;
    const id = req.params.id;
    const {categoryid, name, amount, dayOfMonth} = req.body;

    const sql =  `UPDATE entry_planner
        SET category_id = ?,
			name = ?,
            amount = ?,
            day_of_month = ?
        WHERE id = ?
        AND user_id = ?;
    `;

    const [result] = await db.query(sql, [categoryid, name, amount, dayOfMonth, id, userid]);

    if (result.affectedRows === 0) return res.status(404).json({message: "Entry not found"});

    return res.status(201).json({message: "Planned entry modified"});
});
// DELETE /api/private/planned-entries/:id
app.patch('/api/private/planned-entries/:id/use', async(req, res) => {
    const userid = req.userid;
    const id = req.params.id;

    const sql = `UPDATE entry_planner
        SET active = NOT active
        WHERE id = ?
        AND user_id = ?;
    `;

    const [result] = await db.query(sql, [id, userid]);

    if (result.affectedRows === 0) return res.status(404).json({message: "entry not found"});

    return res.status(200).json({message: "planned entry activated/deactivated"});
});


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