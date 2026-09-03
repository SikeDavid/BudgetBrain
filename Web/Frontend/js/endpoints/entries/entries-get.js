/*
"entry": {
    "route": "GET /api/entries/:id",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": {
        "entry_id": 1,
        "name": "Élelmiszer",
        "description": "Bolt",
        "amount": -12000,
        "date": "2026-04-03",
        "completed": 1
    }
},
*/

function entriesGet(id) {
    ajax({
        method: "GET",
        url: `${API_PATH}/entries/${id}`,
        //body: body,
        auth: true,
        callbackSuccess: entriesGetSuccess,
        callbackError: entriesGetError
    });
}

/******************************/
/******************************/
/******************************/

function entriesGetSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function entriesGetError(result) {
    conError(result);
}
