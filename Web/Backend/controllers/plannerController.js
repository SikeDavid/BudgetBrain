// router.get('/planner/', controllerEntryPlannerGet);
// export async function controllerEntryPlannerGet(req, res) {
//     const userid = req.user.id;

//     try {
//         const data = await modelEntryPlannerGet(userid);

//         if (data.length === 0) return res.status(404).json({message: "Planned entries not found"});

//         return res.status(200).json(data)
//     } catch (err) {
//         console.error("Server error", err);
//         return res.status(500).json({message: "Server error"});
//     }


// }
// router.post('/planner/', controllerEntryPlannerAdd);
// router.patch('/planner/', controllerEntryPlannerEdit);
// router.delete('/planner/', controllerEntryPlannerDel);