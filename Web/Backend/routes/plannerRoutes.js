import express from 'express';

import {
    controllerEntryPlannerGet,
    controllerEntryPlannerAdd,
    controllerEntryPlannerStatus
} from '../controllers/plannerController.js';

const router = express.Router();

router.get('/', controllerEntryPlannerGet);
router.post('/', controllerEntryPlannerAdd);
router.patch('/:id/status', controllerEntryPlannerStatus)
// router.post('/planner/', controllerEntryPlannerAdd);
// router.patch('/planner/', controllerEntryPlannerEdit);
// router.delete('/planner/', controllerEntryPlannerDel);

export default router;