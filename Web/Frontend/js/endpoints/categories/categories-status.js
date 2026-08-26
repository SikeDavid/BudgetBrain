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
        caller: categoriesStatus,
        method: "PATCH",
        url: `${API_PATH}/categories/${id}/status`,
        //body: body,
        auth: true,
        callbackSuccess: categoriesStatusSuccess,
        callbackError: categoriesStatusError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesStatusSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function categoriesStatusError(response) {
    console.error(response);

    return false;
}
