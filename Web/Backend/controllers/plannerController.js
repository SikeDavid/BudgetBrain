import {
    modelEntryPlannerCreate,
    modelEntryPlannerGet,
    modelEntryPlannerUpdate,
    modelEntryPlannerStatus,

} from '../models/plannerModel.js';

// Create
export async function controllerEntryPlannerCreate(req, res) {
    const userid = req.user.id;
    const {categoryid, name, amount, dayofmonth} = req.body;

    try {
        const result = await modelEntryPlannerAdd(userid, categoryid, name, amount, dayofmonth);

        if (result.affectedRows === 0) return res.status(400).json({message: "Error"});

        return res.status(201).json({message: "Planned entry created", plannedEntryid: result.insertId});
    } catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}
// Read
export async function controllerEntryPlannerGet(req, res) {
    const userid = req.user.id;

    try {
        const data = await modelEntryPlannerGet(userid);

        if (data.length === 0) return res.status(404).json({message: "Planned entries not found"});

        return res.status(200).json(data)
    } catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}
// Update
export async function controllerEntryPlannerUpdate(req, res) {
    const userid = req.user.id;
    const plannedEntryId = req.params.id;
    const data = req.body;

    try {
        const result = await modelEntryPlannerUpdate(userid, plannedEntryId, data);

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
// Delete
export async function controllerEntryPlannerStatus(req, res) {
    const userid = req.user.id;
    const plannedEntryId = req.params.id;

    try {
        const result = await modelEntryPlannerStatus(userid, plannedEntryId);

        if (result.affectedRows === 0) return res.status(400).json({message: "Error"});

        return res.status(200).json({message: "Planned entry status changed"});
    } catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}