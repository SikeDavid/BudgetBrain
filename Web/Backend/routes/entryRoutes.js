import express from 'express';
import {
    controllerEntryQuery,
    controllerEntryCreate,
    controllerEntryToggleComplete,
    controllerEntryDelete,
    controllerEntryUpdate
} from '../controllers/entryController.js';

const router = express.Router();

router.get('/:year/:month', controllerEntryQuery);
router.post('/add', controllerEntryCreate);
router.patch('/complete/:id', controllerEntryToggleComplete);
router.delete('/delete/:id', controllerEntryDelete);
router.patch('/update/:id', controllerEntryUpdate);

export default router;

// PATCH /api/private/entries/:id
// app.patch('/api/private/entries/:id', async(req, res) => {
//     const id = req.userid;
//     const entryid = req.params.id;
//     const {categoryid, amount, description, date, completed} = req.body;

//     try {
//         const sql = `UPDATE entries
//             SET category_id = ?,
//                 amount = ?,
//                 description = ?,
//                 date = ?,
//                 completed = ?
//             WHERE entry_id = ?
//             AND user_id = ?
//         `;

//         const [result] = await db.query(sql, [categoryid, amount, description, date, Number(completed), entryid, id]);

//         if (result.affectedRows === 0) {
//             return res.status(404).json({message: "Entry not found"});
//         }

//         return res.status(200).json({message: "entry updated"});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });

// dashboard - Monthly balace, income, expense, last 5 entry
// app.get('/api/private/dashboard', async(req, res) => {
//     const id = req.userid;
//     const year = new Date().getFullYear();
//     const month = new Date().getMonth() + 2;

//     try {
//         const sqlGenerateEntryPlanner = `CALL generate_entry_planner(?, ?, ?);`;
//         await db.query(sqlGenerateEntryPlanner, [id, year, month]);

//         const sqlBalance = `
//             SELECT
//                 COALESCE(SUM(
//                     CASE
//                         WHEN c.type = 'income' THEN e.amount
//                         WHEN c.type = 'expense' THEN -e.amount
//                     END
//                 ), 0) AS monthly_balance,
//                 COALESCE(SUM(
//                     CASE WHEN c.type = 'income'THEN e.amount ELSE 0 END
//                 ), 0) AS monthly_income,
//                 COALESCE(SUM(
//                     CASE WHEN c.type = 'expense'THEN -e.amount ELSE 0 END
//                 ), 0) AS monthly_expense
//             FROM entries e
//             JOIN categories c on e.category_id =c.category_id
//             WHERE e.user_id = ?
//             AND YEAR(e.date) = ?
//             AND MONTH(e.date) = ?
//         `;

//         const [balance] = await db.query(sqlBalance, [id, year, month]);
//         const summary = balance[0];

//         const sqlEntries = `SELECT 
//                         e.entry_id,
//                         CASE
//                             WHEN c.type = 'expense' THEN -e.amount
//                             ELSE e.amount
//                         END AS amount,
//                         e.description,
//                         e.date,
//                         e.completed,
//                         e.planned_entry_id,
//                         c.name AS category_name,
//                         c.type
//                     FROM entries e
//                     JOIN categories c ON e.category_id = c.category_id
//                     WHERE e.user_id = ?
//                         AND e.completed = true
//                         AND YEAR(e.date) = ?
//                         AND MONTH(e.date) = ?
//                     ORDER BY
//                         e.date DESC, e.entry_id DESC
//                     LIMIT 5
//         `;

//         const [entries] = await db.query(sqlEntries, [id, year, month]);
//         return res.status(200).json({
//             balance: summary.monthly_balance,
//             income: summary.monthly_income,
//             expense: summary.monthly_expense,
//             entries: entries
//             });
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });