/*
"update": {
    "route": "PATCH /api/categories/:id/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "name": "something",
        "type": "expense/income",
        "in_use": 0
    }
}
*/

function categoriesUpdate(id) {
    const body = {
        "name": e_in_catUp_addName.value,
        "type": e_sel_catUp_item.options[e_sel_catUp_item.selectedIndex].value,
        "in_use": e_cbx_catUp_inUse.checked ? 1 : 0
    };

    ajax({
        method: "PATCH",
        url: `${API_PATH}/categories/${id}`,
        body: body,
        auth: true,
        callbackSuccess: categoriesUpdateSuccess,
        callbackError: categoriesUpdateError
    });
}

/******************************/
/******************************/
/******************************/

function categoriesUpdateSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function categoriesUpdateError(response) {
    console.error(response);
}
