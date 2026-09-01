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
    console.log(body);
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
    console.log(result);
}

/******************************/
/******************************/
/******************************/

function categoriesUpdateError(result) {
    console.error(result);
}
