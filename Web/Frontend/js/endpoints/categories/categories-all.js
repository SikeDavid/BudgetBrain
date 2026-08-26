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
}

/******************************/
/******************************/
/******************************/

function categoriesAllSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function categoriesAllError(response) {
    console.error(response);
}
