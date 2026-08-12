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
    "route": "POST /api/categories/add",
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
    xhr.open("POST", "http://localhost:5000/api/categories/add");

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
        "name": "Valami",
        "type": "expense",
        "in_use": 0
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
"update": {
    "route": "PATCH /api/categories/update/:id",
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
    xhr.open("PATCH", `http://localhost:5000/api/categories/update/${id}`);

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
        "type": "expense",
        "in_use": 0
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
"status": {
    "route": "PATCH /api/categories/status/:id",
    "header": {
        "authorization": "Bearer: (token)"
    }
}
*/





