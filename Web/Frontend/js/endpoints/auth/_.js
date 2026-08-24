
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
    };

    ajax({
        method: "POST",
        url: `${API_PATH}/`,
        body: body,
        auth: true,
        callbackSuccess: Success,
        callbackError: Error
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


