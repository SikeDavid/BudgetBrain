/*
"update": {
    "route": "PATCH /api/entries/:id",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "category_id": "id",
        "name": "Fizetés",
        "description": "Fizetés",
        "amount": 999,
        "date": "2026-04-01",
        "completed": 1
    }
},
*/

function entriesUpdate(id, body) {
    ajax({
        method: "PATCH",
        url: `${API_PATH}/entries/${id}`,
        body: body,
        auth: true,
        callbackSuccess: entriesUpdateSuccess,
        callbackError: entriesUpdateError
    });
}

/******************************/
/******************************/
/******************************/

function entriesUpdateSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function entriesUpdateError(result) {
    conError(result);
}
