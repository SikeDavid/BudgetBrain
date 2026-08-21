
/******************************/
/******************************/
/******************************/
/*
"registration": {
    "route": "POST /api/auth/registration",
    "body": {
        "username": "username",
        "email": "email",
        "password": "password"
    },
    "response": {
        "message": "Registration successful",
        "userid": "userId"
    }
}
*/

function registration() {

    const body = {
        "username": e_reg_userName.value,
        "email": e_reg_email.value,
        "password": e_reg_password.value
    };

    ajax({method: "POST", url: `${API_PATH}/auth/registration`, body: body, callbackSuccess: () => {alert("Success!");}, callbackError: () => {alert("Error!");}});

    return;

    const xhr = new XMLHttpRequest();
    xhr.open("POST", `${API_PATH}/auth/registration`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            console.error(xhr.responseText);
            alert("Regisztráció sikertelen!\nFelhasználói név vagy e-mail cím már foglalt.");
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
        alert("Sikeres regisztráció!");
        //currentUser.id = ;
        currentUser.name = e_reg_userName;
        //loginDirect();

        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");
/*
    const body = {
        "username": e_reg_userName.value,
        "email": e_reg_email.value,
        "password": e_reg_password.value
    };

    xhr.send(JSON.stringify(body));
*/
    return true;
}

/******************************/
/******************************/
/******************************/
/*
"login": {
    "route": "POST /api/auth/login",
    "body": {
        "username": "username",
        "password": "password"
    },
    "response": {
        "user": {
        "userId": "user_id",
        "username": "username"
        },
        "accesToken": "accessToken",
        "refreshToken": "refreshtoken"
    }
}
*/

function login() {

    const xhr = new XMLHttpRequest();
    xhr.open("POST", `${API_PATH}/auth/login`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            alert(`Belépés sikertelen!\n${response.message}`);
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);

        currentUser.accessToken = response.accessToken;
        currentUser.refreshToken = response.refreshToken;

        e_login_accessToken.value = response.accessToken;
        e_login_refreshToken.value = response.refreshToken;
        copyTokens();

        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");

    const body = {
        "username": e_login_userName.value,
        "password": e_login_password.value
    };

    xhr.send(JSON.stringify(body));

    return true;
}

/******************************/
/******************************/
/******************************/
/*
"logout": {
    "route": "POST /api/auth/logout",
    "body": {
        "refreshToken": "refreshtoken"
    },
    "response": {
        "message": "Logout success"
    }
}
*/

function logout() {
    const xhr = new XMLHttpRequest();
    xhr.open("POST", `${API_PATH}/auth/logout`);

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
    };

    xhr.setRequestHeader("Content-Type", "application/json");

    const body = {
        "refreshToken": currentUser.refreshToken
    };

    xhr.send(JSON.stringify(body));

    return true;
}

/******************************/
/******************************/
/******************************/
/*
"refreshToken": {
    "route": "POST /api/auth/refreshtoken",
    "body": {
        "refreshToken": "refreshToken"
    },
    "response": {
        "accesstoken": "accessToken"
    }
}
*/

function refreshDaToken() {
    const xhr = new XMLHttpRequest();
    xhr.open("POST", `${API_PATH}/auth/refreshtoken`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
// Reported bug: > https://trello.com/c/1POKR1NS/15-bug-accestoken-vs-accesstoken
/*        accessToken = response.accessToken;
        e_accessToken.value = response.accessToken;*/
        currentUser.accessToken = response.accessToken;
        e_accessToken.value = response.accessToken;

        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");

    const body = {
        "refreshToken": currentUser.refreshToken
    };

    xhr.send(JSON.stringify(body));

    return true;
}




