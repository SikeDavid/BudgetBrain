/*
"categories": {
    "route": "GET /api/categories/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": "list of categories"
}
*/

function categoriesAll() {
    const body = {
    };

    ajax({
        caller: categoriesAll,
        method: "GET",
        url: `${API_PATH}/categories`,
        //body: body,
        auth: true,
        callbackSuccess: categoriesAllSuccess,
        callbackError: categoriesAllError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesAllSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesAllError(response) {
    console.error(response);

    return false;
}
