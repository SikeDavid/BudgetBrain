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
        caller: entriesComplete,
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

function entriesCompleteSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function entriesCompleteError(response) {
    console.error(response);
}
