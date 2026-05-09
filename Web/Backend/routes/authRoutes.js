import express from 'express';
import {
    login,
    registration
} from '../controllers/authController.js';

const router = express.Router();

router.post('/login', login);
router.post('/registration', registration);
// logout
// refresh token
// activate account
// forget password


export default router;