/*
"status": {
    "route": "PATCH /api/categories/:id/status/",
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/

function categoriesStatus(id) {
    ajax({
        method: "PATCH",
        url: `${API_PATH}/categories/${id}/status`,
        //body: body,
        auth: true,
        callbackSuccess: categoriesStatusSuccess,
        callbackError: categoriesStatusError
    });
}

/******************************/
/******************************/
/******************************/

function categoriesStatusSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function categoriesStatusError(result) {
    conError(result);
}
