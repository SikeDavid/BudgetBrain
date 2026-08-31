/*
"status": {
    "route": "PATCH /api/categories/:id/status/",
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/

function categoriesStatus(id) {
    const body = {
    };

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

function categoriesStatusSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function categoriesStatusError(response) {
    console.error(response);
}
