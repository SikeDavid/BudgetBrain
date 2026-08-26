/*
"add": {
    "route": "POST /api/categories/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "name": "Valami",
        "type": "expense/income",
        "in_use": 0
    }
}
*/

function categoriesAdd() {
    const body = {
        "name": e_in_cat_addName.value,
        "type": e_sel_cat_item.options[e_sel_cat_item.selectedIndex].value,
        "in_use": e_cbx_cat_inUse.checked ? 1 : 0
    };

    ajax({
        caller: categoriesAdd,
        method: "POST",
        url: `${API_PATH}/categories`,
        body: body,
        auth: true,
        callbackSuccess: categoriesAddSuccess,
        callbackError: categoriesAddError
    });
}

/******************************/
/******************************/
/******************************/

function categoriesAddSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function categoriesAddError(response) {
    console.error(response);
}
