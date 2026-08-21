import db from "../database.js";

// create by user
// CREATE
export async function modelFeedbackUser(userid, title, message) {
    const sql = `
    INSERT INTO feedback (title, message, user_id) VALUES
	    (?, ?, ?);
    `;

    const [result] = await db.query(sql, [title, message, userid]);

    return result;
    
}
// CREATE
export async function modelFeedbackQuest(email, title, message) {
    const sql = `
    INSERT INTO feedback (title, message, foreign_email) VALUES
        (?, ?, ?);
    `;

    const [result] = await db.query(sql, [title, message, email]);

    return result;
}
// READ
export async function modelFeedbackGet() {
    const sql = `
        SELECT
            f.feedback_id,
            f.title,
            f.message,
            u.username,
            f.foreign_email,
            f.is_read
        FROM feedback f
        LEFT JOIN users u ON u.user_id = f.user_id;
        `;

    const [result] = await db.query(sql);

    return result;
}
// UPDATE
export async function modelFeedbackRead(feedbackid) {
    const sql = `
        UPDATE feedback
        SET is_read = NOT is_read
        WHERE feedback_id = ?;
    `;

    const [result] = await db.query(sql, [feedbackid]);

    return result;
}
// DELETE
export async function modelFeedbackDelete(feedbackid) {
    const sql = `
        DELETE FROM feedback
        WHERE feedback_id = ?;
    `;
    
    const [result] = await db.query(sql, [feedbackid]);

    return result;
}


// create by quest
// mark as readed
// delete feedback