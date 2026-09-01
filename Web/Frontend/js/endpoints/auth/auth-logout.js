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

function logout(body) {
    ajax({
        method: "POST",
        url: `${API_PATH}/auth/logout`,
        body: body,
        auth: false,
        callbackSuccess: logoutSuccess,
        callbackError: logoutError
    });
}

/******************************/
/******************************/
/******************************/

function logoutSuccess(result) {
    console.log(result);
    alert("Sikeres kilépés!");
}

/******************************/
/******************************/
/******************************/

function logoutError(result) {
    console.error(result);
    alert("Sikertelen kilépés!");
}
