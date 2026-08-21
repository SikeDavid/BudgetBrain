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
    xhr.open("GET", `${API_PATH}/categories/`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            return false;
        }

        categories = JSON.parse(xhr.responseText);
        console.log(categories);
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
    xhr.open("POST", `${API_PATH}/categories`);

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
/*
    const body = {
        "name": "Valami",
        "type": "expense/income",
        "in_use": 0
    };
*/

    const body = {
        "name": "Valami3",
        "type": "expense",
        "in_use": 1
    };

    xhr.send(JSON.stringify(body));

    return true;
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
    xhr.open("PATCH", `${API_PATH}/categories/${id}`);

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
        "name": "Valami",
        "type": "income",
        "in_use": 10
    };

    xhr.send(JSON.stringify(body));

    return true;
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
    xhr.open("PATCH", `${API_PATH}/categories/${id}/status/`);

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





