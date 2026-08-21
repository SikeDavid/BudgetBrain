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
    xhr.open("GET", `${API_PATH}/planner`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.setRequestHeader("Authorization", `Bearer ${currentUser.accessToken}`);

    xhr.send();

    return true;
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
    xhr.open("POST", `${API_PATH}/planner`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.setRequestHeader("Authorization", `Bearer ${currentUser.accessToken}`);

    const body = {
        "categoryid": 2,
        "name": "valami teszt",
        "amount": 3000000,
        "dayofmonth": 30
    };

    xhr.send(JSON.stringify(body));

    return true;
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
    xhr.open("GET", `${API_PATH}/planner/${id}/status`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.setRequestHeader("Authorization", `Bearer ${currentUser.accessToken}`);

    xhr.send();

    return true;
}
