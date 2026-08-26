/*
"delete": {
    "route": "DELETE /api/entries/:id",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": {
        "message": "Entry deleted"
    }
}
*/

function entriesDelete(id) {
    const body = {
    };

    ajax({
        method: "DELETE",
        url: `${API_PATH}/entries/${id}`,
        //body: body,
        auth: true,
        callbackSuccess: entriesDeleteSuccess,
        callbackError: entriesDeleteError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function entriesDeleteSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function entriesDeleteError(response) {
    console.error(response);

    return false;
}
