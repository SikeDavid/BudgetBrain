/*
"status": {
    "route": "GET /api/planner/:id/status", -> PATCH!!!
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/

function plannedEntriesStatus(id) {
    ajax({
        method: "PATCH",
        url: `${API_PATH}/planner/${id}/status`,
        //body: body,
        auth: true,
        callbackSuccess: plannedEntriesStatusSuccess,
        callbackError: plannedEntriesStatusError
    });
}

/******************************/
/******************************/
/******************************/

function plannedEntriesStatusSuccess(result) {
    console.log(result);
}

/******************************/
/******************************/
/******************************/

function plannedEntriesStatusError(result) {
    console.error(result);
}
