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

function refreshToken(body) {
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

function refreshTokenSuccess(result) {
    conLog(result);
    currentUser.accessToken = result.response.accessToken;
    if (isDebug())
        e_in_dbgApi_authRefresh_accessToken.value = result.response.accessToken;
}

/******************************/
/******************************/
/******************************/

function refreshTokenError(result) {
    conError("Oh no! Token refresh is a no-no! Refresh token must have expired!");
    conError(result);
}

