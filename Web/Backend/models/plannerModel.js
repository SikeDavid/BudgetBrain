import db from "../database.js";

// Create
export async function modelEntryPlannerCreate(userid, categoryid, name, amount, dayofmonth) {
    const sql = `
        INSERT INTO entry_planner
            (user_id, category_id, name, amount, day_of_month)
            VALUES (?, ?, ?, ?, ?)
    `;

    const [result] = await db.query(sql, [userid, categoryid, name, amount, dayofmonth]);

    return result;
}
// Read
export async function modelEntryPlannerGet(userid) {
    const sql = `
        SELECT * FROM entry_planner WHERE user_id = ?
    `;

    const [result] = await db.query(sql, userid);

    return result;
}
// Update
export async function modelEntryPlannerUpdate(userid, plannedEntryId, data) {
    const fields = [];
    const values = [];

    if (data.categoryid !== undefined) {
        fields.push("category_id = ?");
        values.push(data.categoryid);
    }

    if (data.name !== undefined) {
        fields.push("name = ?");
        values.push(data.name);
    }

    if (data.amount !== undefined) {
        fields.push("amount = ?");
        values.push(data.amount);
    }

        
    if (data.dayofmonth !== undefined) {
        fields.push("day_of_month = ?");
        values.push(data.dayofmonth);
    }

    if (fields.length === 0) return
    const sql = `
        UPDATE entry_planner
        SET ${fields.join(", ")}
        WHERE id = ?
        AND user_id = ?
    `;

    values.push(plannedEntryId, userid);

    const [result] = await db.query(sql, values);
    return result;
}
// Delete
export async function modelEntryPlannerStatus(userid, plannedEntryId) {
    const sql = `
        UPDATE entry_planner
            SET active = NOT active
            WHERE user_id = ?
            AND id = ?
    `;

    const [result] = await db.query(sql, [userid, plannedEntryId]);

    return result;
}