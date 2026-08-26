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
        caller: plannedEntriesAll,
        method: "GET",
        url: `${API_PATH}/planner`,
        //body: body,
        auth: true,
        callbackSuccess: plannedEntriesAllSuccess,
        callbackError: plannedEntriesAllError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAllSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function plannedEntriesAllError(response) {
    console.error(response);

    return false;
}
