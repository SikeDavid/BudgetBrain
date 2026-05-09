import express, { json } from 'express';
import dotenv from 'dotenv';
import cors from 'cors';

import db from './database.js';
import { databaseTest } from './database.js';

import authRoutes from './routes/authRoutes.js';
import authMiddleware from './middleware/authMiddleware.js';
import entryRoutes from './routes/entryRoutes.js';

dotenv.config();
const app = express();
const port = process.env.PORT;

app.use(cors());
app.use(express.json())

app.use((req, res, next) => {
    console.log(`${new Date().toISOString()}`);
    console.log(`\t${req.method} ${req.path}`);
    if(req.body) {
        console.log(`\tbody: ${JSON.stringify(req.body)}`);
    };
    next();
});

app.get('/', (req, res) => {
    res.status(200).json({
        app: "BudgetBrain API",
        version: "0.1.0",
        status: "running...",
        endpoints: {
            auth: {
                login: "POST /api/auth/login",
                registration: "POST /api/auth/registration",
            },
            entries: {
                entries: {
                    list: "GET /api/entries/:year/:month",
                    add: "POST /api/entries/add",
                    status: "PATCH /api/entries/complete/:id",
                    update: "PATCH /api/entries/update/:id",
                    delete: "DELETE /api/entries/delete/:id"
                },
                categories: {

                },
                plannedEntries: {

                }
            }
        }
    });
});

app.use('/api/auth', authRoutes);
app.use('/api/entries', authMiddleware, entryRoutes);

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