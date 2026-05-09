// // GET /api/private/categories
// app.get('/api/private/categories', async(req, res) => {
//     const userid = req.userid;
//     try {
//         const sql = ` SELECT
//             c.category_id,
//             c.name,
//             c.type
//             FROM categories c
//             JOIN users u ON c.user_id = u.user_id
//             WHERE c.user_id = ?
//             AND c.in_use = true
//         `;

//         const [result] = await db.query(sql, [userid]);

//         return res.status(200).json({result});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });

// // POST /api/private/categories
// app.post('/api/private/categories', async(req, res) => {
//     const id = req.userid;
//     const {name, type} = req.body;
//     const in_use = true;
//     try {
//         const sql = `INSERT INTO categories (user_id, name, type, in_use) VALUES (?, ?, ?, ?)`;

//         await db.query(sql, [id, name, type, in_use]);

//         return res.status(201).json({message: "category created"});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });
// // PATCH /api/private/categories/:id

// // DELETE /api/private/categories/:id
// app.patch('/api/private/categories/:categoryid/status', async(req, res) => {
//     const id = req.userid;
//     const categoryid = req.params.categoryid;
//     const { status } = req.body;

//     if (typeof status !== "boolean") return res.status(400).json({ message: "status must be boolean"});

//     try {
//         const sql = `UPDATE categories
//             SET in_use = NOT in_use
//             WHERE category_id = ?
//             AND user_id = ?
//             `;

//         await db.query(sql, [Number(status), categoryid, id]);

//         return res.status(200).json({message: "category removed from active use"});
//     }
//     catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     };
// });