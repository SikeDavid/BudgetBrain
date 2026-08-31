/*
"status": {
    "route": "GET /api/planner/:id/status", -> PATCH!!!
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/

function plannedEntriesStatus(id) {
    const body = {
    };

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

function plannedEntriesStatusSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function plannedEntriesStatusError(response) {
    console.error(response);
}
