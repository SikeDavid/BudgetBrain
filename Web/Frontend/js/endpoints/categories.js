/*
"categories": {
    "route": "GET /api/categories/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "response": "list of categories"
}
*/

function categoriesAll() {
    const xhr = new XMLHttpRequest();
    xhr.open("GET", "http://localhost:5000/api/categories/");

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            console.error(xhr.responseText);
            return;
        }

        categories = JSON.parse(xhr.responseText);
        console.log(categories);
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
    "route": "POST /api/categories/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "name": "Valami",
        "type": "expense/income",
        "in_use": 0
    }
}
*/

function categoriesAdd() {
    const xhr = new XMLHttpRequest();
    xhr.open("POST", "http://localhost:5000/api/categories");

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
/*
    const body = {
        "name": "Valami",
        "type": "expense/income",
        "in_use": 0
    };
*/

    const body = {
        "name": "Valami3",
        "type": "expense2",
        "in_use": 1
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
"update": {
    "route": "PATCH /api/categories/:id/",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "name": "something",
        "type": "expense/income",
        "in_use": 0
    }
}
*/

function categoriesUpdate(id) {
    const xhr = new XMLHttpRequest();
    xhr.open("PATCH", `http://localhost:5000/api/categories/${id}`);

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
        "name": "Valami",
        "type": "income",
        "in_use": 10
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
"status": {
    "route": "PATCH /api/categories/:id/status/",
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/

function categoriesStatus(id) {
    const xhr = new XMLHttpRequest();
    xhr.open("PATCH", `http://localhost:5000/api/categories/${id}/status/`);

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





