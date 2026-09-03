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
}

/******************************/
/******************************/
/******************************/

function entriesCompleteSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function entriesCompleteError(result) {
    conError(result);
}
