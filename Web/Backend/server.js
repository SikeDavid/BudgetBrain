import express, { json, response } from 'express';
import dotenv from 'dotenv';
import cors from 'cors';

import db from './database.js';
import { databaseTest } from './database.js';

import authRoutes from './routes/authRoutes.js';
import authMiddleware from './middleware/authMiddleware.js';
import { refreshToken } from './controllers/authController.js';
import entryRoutes from './routes/entryRoutes.js';
import categoryRoutes from './routes/categoryRoutes.js';
import plannerRouter from './routes/plannerRoutes.js';

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
                login: {
                    route: "POST /api/auth/login",
                    body: {
                        username: "username",
                        password: "password"
                    },
                    response: {
                        user: {
                            userId: "user_id",
                            username: "username"
                        },
                        accesToken: "accessToken",
                        refreshToken: "refreshtoken"
                    }
                },
                registration: {
                    route: "POST /api/auth/registration",
                    body: {
                        username: "username",
                        email: "email",
                        password: "password"
                    },
                    response: {
                        message: "Registration successful",
                        userid: "userId"
                    }
                },
                logout: {
                    route: "POST /api/auth/logout",
                    body: {
                        refreshToken: "refreshtoken"
                    },
                    response: {
                        message: "Logout success"
                    }
                },
                refreshToken: {
                    route: "POST /api/auth/refreshtoken",
                    body: {
                        refreshToken: "refreshToken"
                    },
                    response: {
                        accesstoken: "accessToken"
                    }
                }
            },
            entries: {
                entry: {
                    route: "GET /api/entries/:id",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    response: {
                        "entry_id": 1,
                        "name": "Élelmiszer",
                        "description": "Bolt",
                        "amount": -12000,
                        "date": "2026-04-03",
                        "completed": 1
                    }
                },
                entries: {
                    route: "GET /api/entries?year=2026&month=4",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    response: "list of entries"
                },
                add: {
                    route: "POST /api/entries/",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    body: {
                        categoryid: "id", 
                        amount: "number", 
                        description: "text", 
                        date: "date"
                    },
                    response: {
                        message: "Entry created",
                        entryid: id
                    }
                },
                update: {
                    route: "PATCH /api/entries/:id",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    body: {
                        category_id: "id",
                        name: "Fizetés",
                        description: "Fizetés",
                        amount: 999,
                        date: "2026-04-01",
                        completed: 1
                    }
                },
                complete: {
                    route: "PATCH /api/entries/:id/complete",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    response: {
                        message: "Entry status changed"
                    },
                },
                delete: {
                    route: "DELETE /api/entries/:id",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    response: {
                        message: "Entry deleted"
                    }
                }
            },
            categories: {
                categories: {
                    route: "GET /api/categories/",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    response: "list of categories"
                },
                add: {
                    route: "POST /api/categories/add",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    body: {
                        name: "Valami",
                        type : "expense/income",
                        in_use : 0/1
                    }
                },
                update: {
                    route: "PATCH /api/categories/update/:id",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    body: {
                        name: "something",
                        type : "expense/income",
                        in_use : 0/1
                    }
                },
                status: {
                    route: "PATCH /api/categories/status/:id",
                    header: {
                        authorization: "Bearer: (token)"
                    }
                }
            },
            plannedEntries: {
                plannedEntries: {
                    route: "GET /api/planner/",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    response: "list of planned entries"
                },
                add: {
                    route: "POST /api/planner",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                    body: {
                        categoryid: 2,
                        name: "valami teszt",
                        amount: 3000000,
                        dayofmonth: 30
                    }  
                },
                status: {
                    route: "GET /api/planner/:id/status",
                    header: {
                        authorization: "Bearer: (token)"
                    },
                }
            }
        }
    });
});

// Login, Registration
app.use('/api/auth', authRoutes);

// Token test
app.get('/test/token', authMiddleware, (req, res) => {
    return res.status(418).json({
        message: "success accesstoken validation",
        userid: req.user.id,
        username: req.user.username
    });
});

app.use('/api/entries', authMiddleware, entryRoutes);

app.use('/api/categories', authMiddleware, categoryRoutes);
app.use('/api/planner', authMiddleware, plannerRouter);

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