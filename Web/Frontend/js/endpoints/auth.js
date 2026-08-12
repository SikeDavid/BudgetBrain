
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
    const xhr = new XMLHttpRequest();
    xhr.open("POST", "http://localhost:5000/api/auth/registration");

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
    //xhr.setRequestHeader("Authorization", "Bearer ...");

/*
    const body = {
        "username": "TestUser01",
        "email": "testuser01@email.com",
        "password": "Password01!"
    };
*/

    const body = {
        "username": e_reg_userName.value,
        "email": e_reg_email.value,
        "password": e_reg_password.value
    };

    xhr.send(JSON.stringify(body));

    //return true;
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
    xhr.open("POST", "http://localhost:5000/api/auth/login");

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            console.error(xhr.responseText);
            return;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
        accessToken = response.accessToken;
        e_login_accessToken.value = response.accessToken;
        refreshToken = response.refreshToken;
        e_login_refreshToken.value = response.refreshToken;
    };

    xhr.onerror = () => {
        console.error("Network error.");
    };

    xhr.setRequestHeader("Content-Type", "application/json");
/*
    const body = {
        "username": "TestUser01",
        "password": "Password01!"
    };
*/
    const body = {
        "username": e_login_userName.value,
        "password": e_login_password.value
    };

    xhr.send(JSON.stringify(body));
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
    xhr.open("POST", "http://localhost:5000/api/auth/logout");

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

    const body = {
        "refreshToken": refreshToken
    };

    xhr.send(JSON.stringify(body));
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
    xhr.open("POST", "http://localhost:5000/api/auth/refreshtoken");

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            console.error(xhr.responseText);
            return;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
// Reported bug: > https://trello.com/c/1POKR1NS/15-bug-accestoken-vs-accesstoken
/*        accessToken = response.accessToken;
        e_accessToken.value = response.accessToken;*/
        accessToken = response.accesstoken;
        e_accessToken.value = response.accesstoken;
    };

    xhr.onerror = () => {
        console.error("Network error.");
    };

    xhr.setRequestHeader("Content-Type", "application/json");

    const body = {
        "refreshToken": refreshToken
    };

    xhr.send(JSON.stringify(body));
}




