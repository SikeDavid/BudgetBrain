import {
    modelEntryCreate,
    modelEntryDashboard,
    modelEntriesGet,
    modelEntryGet,
    modelEntryPlannerGenerate,
    modelEntryUpdate,
    modelEntryComplete,
    modelEntryDelete

} from "../models/entryModel.js";

// Create
export async function controllerEntryCreate(req, res) {
    const userid = req.user.id;
    const {categoryid, amount, description, date} = req.body;

    try {
        const result = await modelEntryCreate(userid, categoryid, amount, description, date);

        if (result.affectedRows === 0) {
            return res.status(400).json({message: "Error"});
        }
        return res.status(201).json({message: "Entry created", entryid: result.insertId});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}
// Read
export async function controllerEntryDashboard(req, res) {
    const userid = req.user.id;
    const now = new Date();
    const year = now.getFullYear();
    const month = now.getMonth() + 1;

    try {
        const data = await modelEntryDashboard(userid, year, month);

        if (data.length === 0) return res.status(404).json({message: "no entries"});

        return res.status(200).json(data);
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}
// Read
export async function controllerEntriesGet(req, res) {
    const userid = req.user.id;
    const now = new Date();
    const year = Number(req.query.year) || now.getFullYear();
    const month = Number(req.query.month) || now.getMonth() + 1;

    if (month < 1 || month > 12) {
        return res.status.status(400).json({message: "Invalid month"});
    }

    const currentDate = now.getFullYear() * 12 + now.getMonth() + 1;
    const requestDate = year * 12 + month;

    try {
        if (requestDate >= currentDate) {
            await modelEntryPlannerGenerate(userid, year, month);
        }

        const data = await modelEntriesGet(userid, year, month);

        if (data.length === 0) return res.status(404).json({message: "no entry"});

        return res.status(200).json(data);
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}
// Read
export async function controllerEntryGet(req, res) {
    const userid = req.user.id;
    const entryid = req.params.id;
    try {
        const data = await modelEntryGet(userid, entryid);
        if (data.length === 0) return res.status(404).json({message: "Entry not found"});

        return res.status(200).json(data);
    } catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}
// Update
export async function controllerEntryUpdate(req, res) {
    const userid = req.user.id;
    const entryid = req.params.id;
    const data = req.body;

    try {
        const result = await modelEntryUpdate(userid, entryid, data);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "Entry not found"});
        }

        return res.status(200).json({message: "Entry updated"});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}
// Update
export async function controllerEntryToggleComplete(req, res) {
    const userid = req.user.id;
    const entryid = req.params.id;

    try{
        const result = await modelEntryComplete(userid, entryid);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "Entry not found"});
        }

        return res.status(200).json({message: "Entry status changed"});
    }
    catch (err) {
        console.error("Server error", err);

        return res.status(500).json({message: "Server error"});
    }
}
// Delete
export async function controllerEntryDelete(req, res) {
    const userid = req.user.id;
    const entryid = req.params.id;

    try{
        const result = await modelEntryDelete(userid, entryid);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "Entry not found"});
        }

        return res.status(200).json({message: "Entry deleted"});
    }
    catch (err) {
        console.error("Server error", err);

        return res.status(500).json({message: "Server error"});
    }
}



