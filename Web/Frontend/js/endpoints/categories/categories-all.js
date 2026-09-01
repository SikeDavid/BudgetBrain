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
    ajax({
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

function categoriesAllSuccess(result) {
    console.log(result);
}

/******************************/
/******************************/
/******************************/

function categoriesAllError(result) {
    console.error(result);
}
