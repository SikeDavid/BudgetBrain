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

function login(body) {
    ajax({
        method: "POST",
        url: `${API_PATH}/auth/login`,
        body: body,
        auth: false,
        callbackSuccess: loginSuccess,
        callbackError: loginError,
        resultAttachable: body
    });
}

/******************************/
/******************************/
/******************************/

function loginSuccess(result) {
    console.log(result);

    currentUser.accessToken = result.response.accessToken;
    currentUser.refreshToken = result.response.refreshToken;

    if (debug != 0) {
        e_in_dbgApi_login_accessToken.value = result.response.accessToken;
        e_in_dbgApi_login_refreshToken.value = result.response.refreshToken;
        copyTokens();
    }
}

/******************************/
/******************************/
/******************************/

function loginError(result) {
    console.error(result);

    if (result.status == 403 &&
        result.response.message == "User is not yet activated" &&
        result.data != null &&
        (typeof result.data.callBackTimes != "number" ||
        typeof result.data.callBackTimes == "number" &&
        result.data.callBackTimes <= 3)) {

        result.data.magicword = "please";
        if (typeof result.data.callBackTimes == "number")
            result.data.callBackTimes++;
        else
            result.data.callBackTimes = 1;
        console.log("Callback time, PLEASE!");
        ajax({
            method: "POST",
            url: `${API_PATH}/auth/login`,
            body: result.data,
            auth: false,
            callbackSuccess: loginSuccess,
            callbackError: loginError,
            resultAttachable: result.data
        });
    }

    alert(`Belépés sikertelen!\n${result.response.message}`);
}
