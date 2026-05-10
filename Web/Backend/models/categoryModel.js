import db from "../database.js";

async function modelCategoriesGet(userid) {
    const sql = ` 
        SELECT
            c.category_id,
            c.name,
            c.type
        FROM categories c
        WHERE c.user_id = ?
        AND c.in_use = 1
    `;

    const [result] = await db.query(sql, [userid]);

    return result;
}

async function modelCategoryAdd(userid, name, type, in_use) {
    const sql = `
        INSERT INTO categories
            (user_id, name, type, in_use)
        VALUES (?, ?, ?, ?)
    `;

    const [result] = await db.query(sql, [userid, name, type, in_use]);

    return result;
}

async function modelCategoryUpdate(userid, categoryid, data) {
    const fields = [];
    const values = [];

    if (data.name !== undefined) {
        fields.push("name = ?");
        values.push(data.name);
    }

    if (data.type !== undefined) {
      fields.push("type = ?");
      values.push(data.type);
    }

    if (data.in_use !== undefined) {
      fields.push("in_use = ?");
      values.push(Number(data.in_use));
    }

    const sql = `
        UPDATE categories
        SET ${fields.join(", ")}
        WHERE user_id = ?
        AND category_id = ?
    `;

    values.push(userid, categoryid);

    const [result] = await db.query(sql, values);
    return result;
}

async function modelCategoryStatus(userid, categoryid) {
    const sql = `UPDATE categories
        SET in_use = NOT in_use
        WHERE user_id = ?
        AND category_id = ?
    `;

    const [result] = await db.query(sql, [userid, categoryid]);
    return result;
}

export {
    modelCategoriesGet,
    modelCategoryAdd,
    modelCategoryUpdate,
    modelCategoryStatus,
}
