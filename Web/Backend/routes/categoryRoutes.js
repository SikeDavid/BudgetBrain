import express from 'express';
import {
    controllerCategoriesGet,
    controllerCategoryAdd,
    controllerCategoryUpdate,
    controllerCategoryStatus,
} from '../controllers/categoryController.js';

const router = express.Router();

router.get('/', controllerCategoriesGet);
router.post('/', controllerCategoryAdd);
router.patch('/:id', controllerCategoryUpdate);
router.patch('/:id/status', controllerCategoryStatus);

export default router;