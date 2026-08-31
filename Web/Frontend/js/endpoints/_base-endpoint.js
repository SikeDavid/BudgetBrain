
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
}

/******************************/
/******************************/
/******************************/

function Success(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function Error(response) {
    console.log(response);
}


