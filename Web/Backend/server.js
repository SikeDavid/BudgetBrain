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

app.listen(port, async() => {
    console.log(`Server is running on port: ${port}`);
    await databaseTest();
});

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