import db from "../database.js";

async function modelEntriesGet(userid, year, month) {
    const sql = `
        SELECT
            e.entry_id,
            c.name,
            e.description,
            CASE
                WHEN c.type = 'expense' THEN -e.amount
                ELSE e.amount
            END AS amount,
            e.date,
            e.completed
            
        FROM entries e
        JOIN categories c ON e.category_id = c.category_id
        WHERE e.user_id = ?
            AND YEAR(e.date) = ?
            AND MONTH(e.date) = ?
    `;

    const [result] = await db.query(sql, [userid, year, month]);

    return result;
}

async function modelEntryAdd(userid, categoryid, amount,description, date) {
    const sql = `
        INSERT INTO entries
            (user_id, category_id, amount, description, date)
        VALUES (?, ?, ?, ?, ?)
    `;

    await db.query(sql, [userid, categoryid, amount, description, date]);
}

async function modelEntryComplete(userid, entryid) {
    const sql = `
        UPDATE entries
            SET completed = NOT completed
            WHERE user_id = ?
            AND entry_id = ?
        `;

    const [result] = await db.query(sql, [userid, entryid]);

    return result;
}

async function modelEntryDelete(userid, entryid) {
    const sql = `
        DELETE
            FROM entries
            WHERE user_id = ?
            AND entry_id = ?
        `;

    const [result] = await db.query(sql, [userid, entryid]);

    return result;
}

async function modelEntryUpdate(userid, entryid, data) {
    const fields = [];
    const values = [];

    if (data.categoryid !== undefined) {
        fields.push("category_id = ?");
        values.push(data.categoryid);
    }

    if (data.amount !== undefined) {
      fields.push("amount = ?");
      values.push(data.amount);
    }

    if (data.description !== undefined) {
      fields.push("description = ?");
      values.push(data.description);
    }

    if (data.date !== undefined) {
      fields.push("date = ?");
      values.push(data.date);
    }

    if (data.completed !== undefined) {
      fields.push("completed = ?");
      values.push(Number(data.completed));
    }

    if (fields.length === 0) {
      throw new Error("No fields to update");
    }

    const sql = `
        UPDATE entries
        SET ${fields.join(", ")}
        WHERE entry_id = ?
        AND user_id = ?
    `;

    values.push(entryid, userid);

    const [result] = await db.query(sql, values);
    return result;
}

export {
    modelEntriesGet,
    modelEntryAdd,
    modelEntryComplete,
    modelEntryDelete,
    modelEntryUpdate
}

