/*
"status": {
    "route": "GET /api/planner/:id/status",
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/

function plannedEntriesStatus(id) {
    const body = {
    };

    ajax({
        caller: plannedEntriesStatus,
        method: "GET",
        url: `${API_PATH}/planner/${id}/status`,
        //body: body,
        auth: true,
        callbackSuccess: plannedEntriesStatusSuccess,
        callbackError: plannedEntriesStatusError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function plannedEntriesStatusSuccess(response) {
    console.log(response);

    return true;
}

/******************************/
/******************************/
/******************************/

function plannedEntriesStatusError(response) {
    console.error(response);

    return false;
}
