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

function plannedEntriesAdd(body) {
    ajax({
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

function plannedEntriesAddSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAddError(result) {
    conError(result);
}
