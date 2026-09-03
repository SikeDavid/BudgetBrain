/*
"entries": {
    "route": "GET /api/entries?year=2026&month=4",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": "list of entries"
},
*/

function entriesGetForMonth(year, month) {
    ajax({
        method: "GET",
        url: `${API_PATH}/entries?year=${year}&month=${month}`,
        //body: body,
        auth: true,
        callbackSuccess: entriesGetForMonthSuccess,
        callbackError: entriesGetForMonthError
    });
}

/******************************/
/******************************/
/******************************/

function entriesGetForMonthSuccess(result) {
    conLog(result);
}

/******************************/
/******************************/
/******************************/

function entriesGetForMonthError(result) {
    conError(result);
}
