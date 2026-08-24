
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
        auth: true,
        callbackSuccess: logoutSuccess,
        callbackError: logoutError
    });

    return true;
}

/******************************/
/******************************/
/******************************/

function logoutSuccess(response) {
    alert("Sikeres kilépés!");
}

/******************************/
/******************************/
/******************************/

function logoutError(response) {
    alert("Sikertelen kilépés!");
}


