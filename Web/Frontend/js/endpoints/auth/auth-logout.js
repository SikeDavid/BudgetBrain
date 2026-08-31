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
    const body = {
        "refreshToken": currentUser.refreshToken
    };

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

function logoutSuccess(response) {
    console.log(response);
    alert("Sikeres kilépés!");
}

/******************************/
/******************************/
/******************************/

function logoutError(response) {
    console.log(response);
    alert("Sikertelen kilépés!");
}
