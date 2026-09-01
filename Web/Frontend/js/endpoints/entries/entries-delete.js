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
    ajax({
        method: "DELETE",
        url: `${API_PATH}/entries/${id}`,
        //body: body,
        auth: true,
        callbackSuccess: entriesDeleteSuccess,
        callbackError: entriesDeleteError
    });
}

/******************************/
/******************************/
/******************************/

function entriesDeleteSuccess(result) {
    console.log(result);
}

/******************************/
/******************************/
/******************************/

function entriesDeleteError(result) {
    console.error(result);
}
