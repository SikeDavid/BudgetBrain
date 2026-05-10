import {
    modelCategoriesGet,
    modelCategoryAdd,
    modelCategoryUpdate,
    modelCategoryStatus,
} from '../models/categoryModel.js';

async function controllerCategoriesGet(req, res) {
    const userid = req.userid;

    try {
        const data = await modelCategoriesGet(userid);
        if (data.length === 0) {
            return res.status(404).json({message: "Categories not found"});
        }

        return res.status(200).json({data});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}

async function controllerCategoryAdd(req, res) {
    const userid = req.userid;
    const {name, type, in_use} = req.body;

    try {
        const data = await modelCategoryAdd(userid, name, type, in_use);

        if(data.affectedRows === 0) {
            return res.status(400).json({message: "some king of error"});
        }

        return res.status(201).json({message: "Category created", categoryid: data.insertId});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}

async function controllerCategoryUpdate(req, res) {
    const userid = req.userid;
    const categoryid = req.params.id;
    const data = req.body;

    try {
        const result = await modelCategoryUpdate(userid, categoryid, data);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "Category not found"});
        }

        return res.status(200).json({message: "Category updated"});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}

async function controllerCategoryStatus(req, res) {
    const userid = req.userid;
    const categoryid = req.params.id;

    try{
        const result = await modelCategoryStatus(userid, categoryid);

        if (result.affectedRows === 0) {
            return res.status(404).json({message: "Category not found"});
        }

        return res.status(200).json({message: "Category status changed"});
    }
    catch (err) {
        console.error("Server error", err);
        return res.status(500).json({message: "Server error"});
    }
}

export {
    controllerCategoriesGet,
    controllerCategoryAdd,
    controllerCategoryUpdate,
    controllerCategoryStatus,
}