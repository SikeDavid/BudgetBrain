// // GET /api/private/planned-entries
// app.get('/api/private/planned-entries', async(req, res) => {
//     const userid = req.userid;

//     try {
//         const sql = ` SELECT
//                 c.name AS category_name,
//                 c.type,
//                 p.name AS entry_name,
//                 ( CASE
//                     WHEN c.type = 'income' THEN p.amount
//                     WHEN c.type = 'expense' THEN -p.amount
//                     END
//                 ) AS amount,
//                 p.day_of_month,
//                 p.active
//             FROM entry_planner p
//             JOIN categories c ON p.category_id = c.category_id
//             WHERE
//                 p.user_id = ?
//         `;

//         const [result] = await db.query(sql, [userid]);

//         return res.status(200).json({result});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });

// // POST /api/private/planned-entries
// app.post('/api/private/planned-entries', async(req, res) => {
//     const userid = req.userid;
//     const {categoryid, name, amount, dayOfMonth} = req.body;

//     try {
//         const sql = `INSERT INTO entry_planner
//                 (user_id, category_id, name, amount, day_of_month)
//             VALUES (?, ?, ?, ?, ?)
//         `;

//         await db.query(sql, [userid, categoryid, name, amount, dayOfMonth]);

//         return res.status(201).json({message: "planned entry created"});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });

// // PATCH /api/private/planned-entries/:id
// app.patch('/api/private/planned-entries/:id', async(req, res) => {
//     const userid = req.userid;
//     const id = req.params.id;
//     const {categoryid, name, amount, dayOfMonth} = req.body;

//     try {
//         const sql =  `UPDATE entry_planner
//             SET category_id = ?,
//                 name = ?,
//                 amount = ?,
//                 day_of_month = ?
//             WHERE id = ?
//             AND user_id = ?
//         `;

//         const [result] = await db.query(sql, [categoryid, name, amount, dayOfMonth, id, userid]);

//         if (result.affectedRows === 0) return res.status(404).json({message: "Entry not found"});

//         return res.status(201).json({message: "Planned entry modified"});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });
// // DELETE /api/private/planned-entries/:id
// app.patch('/api/private/planned-entries/:id/use', async(req, res) => {
//     const userid = req.userid;
//     const id = req.params.id;

//     try {
//         const sql = `UPDATE entry_planner
//             SET active = NOT active
//             WHERE id = ?
//             AND user_id = ?
//         `;

//         const [result] = await db.query(sql, [id, userid]);

//         if (result.affectedRows === 0) return res.status(404).json({message: "entry not found"});

//         return res.status(200).json({message: "planned entry activated/deactivated"});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });