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

function categoriesUpdate(id, body) {
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

function categoriesUpdateSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function categoriesUpdateError(result) {
    conError(result);
}
