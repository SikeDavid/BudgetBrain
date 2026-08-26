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

function entriesAdd() {
    const body = {
        "categoryid": "1",
        "amount": "300",
        "description": "text",
        "date": "2021-12-1" //> In db corrects to 2021-12-01
    };

    ajax({
        caller: entriesAdd,
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

function entriesAddSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function entriesAddError(response) {
    console.error(response);
}
