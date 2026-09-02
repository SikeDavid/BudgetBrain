/*
"add": {
    "route": "POST /api/entries/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "categoryid": "id",
        "amount": "number",
        "description": "text",
        "date": "date"
    },
    "response": {
        "message": "Entry created",
        "entryid": "id"
    }
},
*/

function entriesAdd(body) {
    ajax({
        method: "POST",
        url: `${API_PATH}/entries`,
        body: body,
        auth: true,
        callbackSuccess: entriesAddSuccess,
        callbackError: entriesAddError
    });
}

/******************************/
/******************************/
/******************************/

function entriesAddSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function entriesAddError(result) {
    conError(result);
}
