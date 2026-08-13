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
    const xhr = new XMLHttpRequest();
    xhr.open("GET", `http://localhost:5000/api/planner`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            console.error(xhr.responseText);
            return;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
    };

    xhr.onerror = () => {
        console.error("Network error.");
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.setRequestHeader("Authorization", `Bearer ${accessToken}`);

    xhr.send();
}

/******************************/
/******************************/
/******************************/

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
    const xhr = new XMLHttpRequest();
    xhr.open("POST", `http://localhost:5000/api/planner`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            console.error(xhr.responseText);
            return;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
    };

    xhr.onerror = () => {
        console.error("Network error.");
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.setRequestHeader("Authorization", `Bearer ${accessToken}`);

    const body = {
        "categoryid": 2,
        "name": "valami teszt",
        "amount": 3000000,
        "dayofmonth": 30
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
"status": {
    "route": "GET /api/planner/:id/status",
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/

function plannedEntriesStatus(id) {
    const xhr = new XMLHttpRequest();
    xhr.open("GET", `http://localhost:5000/api/planner/${id}/status`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            console.error(xhr.responseText);
            return;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
    };

    xhr.onerror = () => {
        console.error("Network error.");
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.setRequestHeader("Authorization", `Bearer ${accessToken}`);

    xhr.send();
}
