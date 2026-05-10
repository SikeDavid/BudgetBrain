import express from 'express';
import {
    controllerCategoriesGet,
    controllerCategoryAdd,
    controllerCategoryUpdate,
    controllerCategoryStatus,
} from '../controllers/categoryController.js';

const router = express.Router();

router.get('/', controllerCategoriesGet);
router.post('/add', controllerCategoryAdd);
router.patch('/update/:id', controllerCategoryUpdate);
router.patch('/status/:id', controllerCategoryStatus);

export default router;