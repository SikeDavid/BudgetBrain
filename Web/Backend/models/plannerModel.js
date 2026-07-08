import db from "../database.js";

// router.get('/planner/', controllerEntryPlannerGet);
// router.post('/planner/', controllerEntryPlannerAdd);
// router.patch('/planner/', controllerEntryPlannerEdit);
// router.delete('/planner/', controllerEntryPlannerDel);

export async function modelEntryPlannerGet(userid) {
    const sql = `
        SELECT * FROM entry_planner WHERE user_id = ?
    `;

    const [result] = await db.query(sql, userid);

    return result;
}

export async function modelEntryPlannerAdd(userid, categoryid, name, amount, dayofmonth) {
    const sql = `
        INSERT INTO entry_planner
            (user_id, category_id, name, amount, day_of_month)
            VALUES (?, ?, ?, ?, ?)
    `;

    const [result] = await db.query(sql, [userid, categoryid, name, amount, dayofmonth]);

    return result;
}

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