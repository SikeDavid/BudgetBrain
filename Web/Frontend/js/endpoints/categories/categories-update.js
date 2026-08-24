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
        "name": "Valami",
        "type": "income",
        "in_use": 10
    };

    ajax({
        method: "PATCH",
        url: `${API_PATH}/categories/${id}`,
        body: body,
        auth: true,
        callbackSuccess: categoriesUpdateSuccess,
        callbackError: categoriesUpdateError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesUpdateSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesUpdateError(response) {
    console.error(response);

    return false;
}
