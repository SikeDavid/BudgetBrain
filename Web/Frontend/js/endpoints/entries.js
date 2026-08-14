/*
"entry": {
    "route": "GET /api/entries/:id",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": {
        "entry_id": 1,
        "name": "Élelmiszer",
        "description": "Bolt",
        "amount": -12000,
        "date": "2026-04-03",
        "completed": 1
    }
},
*/

function entriesGet(id) {
    const xhr = new XMLHttpRequest();
    xhr.open("GET", `http://localhost:5000/api/entries/${id}`);

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
"entries": {
    "route": "GET /api/entries?year=2026&month=4",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": "list of entries"
},
*/

function entriesGetForMonth(year, month) {
    const xhr = new XMLHttpRequest();
    xhr.open("GET", `http://localhost:5000/api/entries?year=${year}&month=${month}`);

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
    "route": "POST /api/entries/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "categoryid": "id",
        "amount": "number",
        "description": "text",
        "date": "date"
    },
    "response": {
        "message": "Entry created",
        "entryid": "id"
    }
},
*/

function entriesAdd() {
    const xhr = new XMLHttpRequest();
    xhr.open("POST", `http://localhost:5000/api/entries`);

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
        "categoryid": "1",
        "amount": "300",
        "description": "text",
        "date": "2021-12-1" //> In db corrects to 2021-12-01
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
"update": {
    "route": "PATCH /api/entries/:id",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "category_id": "id",
        "name": "Fizetés",
        "description": "Fizetés",
        "amount": 999,
        "date": "2026-04-01",
        "completed": 1
    }
},
*/

function entriesUpdate(id) {
    const xhr = new XMLHttpRequest();
    xhr.open("PATCH", `http://localhost:5000/api/entries/${id}`);

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
        "category_id": 1,
        "name": "Fizetés",
        "description": "Fizetés",
        "amount": 999,
        "date": "2026-04-01",
        "completed": 1
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
"complete": {
    "route": "PATCH /api/entries/:id/complete",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": {
        "message": "Entry status changed"
    }
},
*/

function entriesComplete(id) {
    const xhr = new XMLHttpRequest();
    xhr.open("PATCH", `http://localhost:5000/api/entries/${id}/complete`);

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
"delete": {
    "route": "DELETE /api/entries/:id",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": {
        "message": "Entry deleted"
    }
}
*/

function entriesDelete(id) {
    const xhr = new XMLHttpRequest();
    xhr.open("DELETE", `http://localhost:5000/api/entries/${id}`);

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
