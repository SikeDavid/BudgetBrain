import express from 'express';

import {
    controllerEntryPlannerCreate,
    controllerEntryPlannerGet,
    controllerEntryPlannerUpdate,
    controllerEntryPlannerStatus
} from '../controllers/plannerController.js';

const router = express.Router();

router.post('/', controllerEntryPlannerCreate);
router.get('/', controllerEntryPlannerGet);
router.patch('/:id', controllerEntryPlannerUpdate);
router.patch('/:id/status', controllerEntryPlannerStatus);

export default router;