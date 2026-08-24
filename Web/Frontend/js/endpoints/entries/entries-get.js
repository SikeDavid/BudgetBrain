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
    const body = {
    };

    ajax({
        method: "GET",
        url: `${API_PATH}/entries/${id}`,
        //body: body,
        auth: true,
        callbackSuccess: entriesGetSuccess,
        callbackError: entriesGetError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function entriesGetSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function entriesGetError(response) {
    console.error(response);

    return false;
}
