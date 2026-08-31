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

function refreshToken() {
    const body = {
        "refreshToken": currentUser.refreshToken
    };

    ajax({
        method: "POST",
        url: `${API_PATH}/auth/refreshtoken`,
        body: body,
        auth: false,
        callbackSuccess: refreshTokenSuccess,
        callbackError: refreshTokenError
    });
}

/******************************/
/******************************/
/******************************/

function refreshTokenSuccess(response) {
    console.log(response);
    currentUser.accessToken = response.accessToken;
    e_accessToken.value = response.accessToken;
}

/******************************/
/******************************/
/******************************/

function refreshTokenError(response) {
    console.error("Token refresh is a no-no! refreshToken expired!");
    console.log(response);
}

