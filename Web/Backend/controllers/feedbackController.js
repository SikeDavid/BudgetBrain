import {
    modelFeedbackGet,
    modelFeedbackUser,
    modelFeedbackQuest,
    modelFeedbackRead,
    modelFeedbackDelete
} from '../models/feedbackModel.js'

// CREATE
export async function controllerFeedbackUser(req, res) {
    const userid = req.user.id;
    // const userid = 1;
    const {title, message} = req.body;

    try {
        const result = await modelFeedbackUser(userid, title, message);

        if (result.affectedRows === 0) {
            return res.status(400).json({message: "Error"});
        }
        return res.status(201).json({message: "Feedback created", feedbackid: result.insertId});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }  
}

// CREATE
export async function controllerFeedbackQuest(req, res) {
    const {email, title, message} = req.body;

    try {
        const result = await modelFeedbackQuest(email, title, message);

        if (result.affectedRows === 0) {
            return res.status(400).json({message: "Error"});
        }
        return res.status(201).json({message: "Feedback created", feedbackid: result.insertId});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }  
}

// READ
export async function controllerFeedbackGet(req, res) {
    try {
        const result = await modelFeedbackGet();
        console.log(result);
        return res.status(200).json(result)
    }
    catch (err) {
        console.error(err);
        return res.status(500).json({message: "Server error"});
    }
}

// UPDATE
export async function controllerFeedbackRead(req, res) {
    const feedbackid = req.params.id;

    try{
        const result = await modelFeedbackRead(feedbackid);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "Feedback not found"});
        }

        return res.status(200).json({message: "Feedback status changed"});
    }
    catch (err) {
        console.error("Server error", err);

        return res.status(500).json({message: "Server error"});
    }
}

// DELETE
export async function controllerFeedbackDelete(req, res) {
    const feedbackid = req.params.id;

    try{
        const result = await modelFeedbackDelete(feedbackid);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "Feedback not found"});
        }

        return res.status(200).json({message: "Feedback deleted"});
    }
    catch (err) {
        console.error("Server error", err);

        return res.status(500).json({message: "Server error"});
    }
}