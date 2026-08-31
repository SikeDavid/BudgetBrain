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
        "categoryid": e_in_entAdd_catId.value,
        "amount": e_in_entAdd_amt.value,
        "description": e_in_entAdd_desc.value,
        //> In db corrects to 2021-12-01 :
        "date": e_in_entAdd_date.value
    };

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

function entriesAddSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function entriesAddError(response) {
    console.error(response);
}
