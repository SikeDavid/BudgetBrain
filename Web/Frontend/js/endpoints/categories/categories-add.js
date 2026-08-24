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
        "name": "Valami3",
        "type": "expense",
        "in_use": 1
    };

    ajax({
        method: "POST",
        url: `${API_PATH}/categories`,
        body: body,
        auth: true,
        callbackSuccess: categoriesAddSuccess,
        callbackError: categoriesAddError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesAddSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesAddError(response) {
    console.error(response);

    return false;
}
