/*
"add": {
    "route": "POST /api/planner",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "categoryid": 2,
        "name": "valami teszt",
        "amount": 3000000,
        "dayofmonth": 30
    }
},
*/

function plannedEntriesAdd() {
    const body = {
        "categoryid": 2,
        "name": "valami teszt",
        "amount": 3000000,
        "dayofmonth": 30
    };

    ajax({
        caller: plannedEntriesAdd,
        method: "POST",
        url: `${API_PATH}/planner`,
        body: body,
        auth: true,
        callbackSuccess: plannedEntriesAddSuccess,
        callbackError: plannedEntriesAddError
    });
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAddSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAddError(response) {
    console.error(response);
}
