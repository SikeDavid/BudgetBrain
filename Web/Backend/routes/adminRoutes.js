import express from 'express';
import {
    controllerGetUsers,
    controllerSetUserStatus,
    controllerSetUserPassword,
    controllerUserDelete
} from '../controllers/adminController.js';

const router = express.Router();

router.get('/getusersdata', controllerGetUsers);
router.patch('/users/:id/status', controllerSetUserStatus);
router.patch('/users/:id/password', controllerSetUserPassword);
router.delete('/users/:id/delete', controllerUserDelete);

export default router;