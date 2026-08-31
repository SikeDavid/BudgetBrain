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
    const body = {
        "username": e_login_userName.value,
        "password": e_login_password.value
    };

    ajax({
        method: "POST",
        url: `${API_PATH}/auth/login`,
        body: body,
        auth: false,
        callbackSuccess: loginSuccess,
        callbackError: loginError
    });
}

/******************************/
/******************************/
/******************************/

function loginSuccess(response) {
    console.log(response);

    currentUser.accessToken = response.accessToken;
    currentUser.refreshToken = response.refreshToken;

    e_login_accessToken.value = response.accessToken;
    e_login_refreshToken.value = response.refreshToken;
    copyTokens();
}

/******************************/
/******************************/
/******************************/

function loginError(response) {
    console.error(response);
    alert(`Belépés sikertelen!\n${response.message}`);
}
