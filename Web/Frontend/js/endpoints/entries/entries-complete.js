/*
"complete": {
    "route": "PATCH /api/entries/:id/complete",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": {
        "message": "Entry status changed"
    }
},
*/

function entriesComplete(id) {
    const body = {
    };

    ajax({
        method: "PATCH",
        url: `${API_PATH}/entries/${id}/complete`,
        //body: body,
        auth: true,
        callbackSuccess: entriesCompleteSuccess,
        callbackError: entriesCompleteError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function entriesCompleteSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function entriesCompleteError(response) {
    console.error(response);

    return false;
}
