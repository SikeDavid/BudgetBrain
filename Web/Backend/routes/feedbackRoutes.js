import express from 'express';
import {
    controllerFeedbackGet,
    controllerFeedbackUser,
    controllerFeedbackQuest,
    controllerFeedbackRead,
    controllerFeedbackDelete
} from '../controllers/feedbackController.js';

const router = express.Router();

router.get('/', controllerFeedbackGet);
router.post('/user', controllerFeedbackUser);
router.post('/quest', controllerFeedbackQuest);
router.patch('/:id', controllerFeedbackRead);
router.delete('/:id', controllerFeedbackDelete);

export default router;