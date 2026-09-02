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

function categoriesAdd(body) {
    ajax({
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

function categoriesAddSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function categoriesAddError(result) {
    conError(result);
}
