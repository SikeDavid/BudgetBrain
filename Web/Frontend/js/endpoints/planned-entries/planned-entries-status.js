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
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function plannedEntriesStatusError(result) {
    conError(result);
}
