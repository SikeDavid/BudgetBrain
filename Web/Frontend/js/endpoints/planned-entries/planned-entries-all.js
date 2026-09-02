/*
"plannedEntries": {
    "route": "GET /api/planner/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": "list of planned entries"
},
*/

function plannedEntriesAll() {
    ajax({
        method: "GET",
        url: `${API_PATH}/planner`,
        //body: body,
        auth: true,
        callbackSuccess: plannedEntriesAllSuccess,
        callbackError: plannedEntriesAllError
    });
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAllSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAllError(result) {
    conError(result);
}
