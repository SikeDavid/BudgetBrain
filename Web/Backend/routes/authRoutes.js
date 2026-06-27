import express from 'express';
import {
    login,
    registration,
    logout,
    refreshToken
} from '../controllers/authController.js';

const router = express.Router();

router.post('/login', login);
router.post('/registration', registration);
// logout
router.post('/logout', logout)
// refresh token
router.post('/refreshtoken', refreshToken);
// activate account
// forget password


export default router;