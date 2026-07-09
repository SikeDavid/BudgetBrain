import express from 'express';
import {
    controllerEntryDashboard,
    controllerEntriesGet,
    controllerEntryGet,
    controllerEntryCreate,
    controllerEntryToggleComplete,
    controllerEntryDelete,
    controllerEntryUpdate
} from '../controllers/entryController.js';

const router = express.Router();

router.get('/dashboard', controllerEntryDashboard);

router.get('/', controllerEntriesGet);
router.get('/:id', controllerEntryGet);
router.post('/', controllerEntryCreate);
router.patch('/:id', controllerEntryUpdate);
router.patch('/:id/complete', controllerEntryToggleComplete);
router.delete('/:id', controllerEntryDelete);


export default router;
