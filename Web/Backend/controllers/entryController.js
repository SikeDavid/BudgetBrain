import {
    modelEntriesGet,
    modelEntryAdd,
    modelEntryComplete,
    modelEntryDelete,
    modelEntryUpdate
} from "../models/entryModel.js";

async function controllerEntryQuery(req, res) {
    const userid = req.userid;
    const {year, month} = req.params;

    try {
    const data = await modelEntriesGet(userid, year, month);
        if (data.length === 0) return res.status(404).json({message: "no entry"});

        return res.status(200).json(data);
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}

async function controllerEntryCreate(req, res) {
    const userid = req.userid;
    const {categoryid, amount, description, date} = req.body;

    try {
        const result = await modelEntryAdd(userid, categoryid, amount, description, date);

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

async function controllerEntryToggleComplete(req, res) {
    const userid = req.userid;
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

async function controllerEntryDelete(req, res) {
    const userid = req.userid;
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

async function controllerEntryUpdate(req, res) {
    const userid = req.userid;
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

export {
    controllerEntryQuery,
    controllerEntryCreate,
    controllerEntryToggleComplete,
    controllerEntryDelete,
    controllerEntryUpdate
};
