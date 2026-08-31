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
    const body = {
    };

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

function plannedEntriesAllSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAllError(response) {
    console.error(response);
}
