function ajax({
        method = "GET",
        url = `${PROTOCOL}://${API_HOST}:${API_PORT}`,
        body = null,
        auth = false,
        callbackSuccess = null,
        callbackError = null,
        callbackData = null,
        tokenRefreshed = false,
        resultAttachable = null
    } = {}) {

    const xhr = new XMLHttpRequest();
    xhr.open(method, url);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            conError(`Request failed. Status: ${xhr.status}`);
            let result = {
                "status": xhr.status,
                "response": JSON.parse(xhr.responseText),
                "data": resultAttachable
            };
            //conLog(result);
//> accessToken expiry: 401 / jwt expired
//> refreshToken expiry: 403 / jwt malformed / jwt not found

            //if (xhr.status == 500) {
                /*>
                    > tokenRefreshed = true -> Theoretical possibility / Edge case: The second non-refreshToken ajax call on a go. Preventing infinite loop: if a token is refreshed but expires by the time we receive it.
                    > response.message == "jwt malformed" -> illegal / nonexisting accessToken
                    > In these cases -> Logout
                <*/
                if (xhr.status == 403 && result.response.message == "User is not yet activated") {
                    //
                }
                else if (tokenRefreshed || xhr.status == 403/*response.message == "jwt malformed"*/) {
                    refreshTokenError(result);
                    return;
                }
                //> AccessToken expired, refreshing:
                if (xhr.status == 401 /*response.message == "Invalid or expired accesstoken"*/) {
                    conError(result);
                    conError("AccessToken expired, refreshing...");
                    const body = {
                        "refreshToken": currentUser.refreshToken
                    };

                    ajax({
                        method: "POST",
                        url: `${API_PATH}/auth/refreshtoken`,
                        body: body,
                        auth: false,
                        callbackSuccess: refreshTokenSuccess,
                        callbackError: refreshTokenError,
                        callbackData: {
                            method: method,
                            url: url,
                            body: body,
                            auth: auth,
                            callbackSuccess: callbackSuccess,
                            callbackError: callbackError
                        }
                    });
                /*}
                else {
                    conError("Unhandled server error.");
                }*/
            }

            else if (callbackError !== null)
                callbackError(result);
            else {
                conLog("callbackError function is null; XHR response is:");
                conError(result);
            }
            return;
        }

        let result = {
            "status": xhr.status,
            "response": JSON.parse(xhr.responseText),
            "data": resultAttachable
        };

        if (callbackData !== null) {
            conLog("Token refresh successful!");
            callbackSuccess(result);
            ajax({
                method: callbackData.method,
                url: callbackData.url,
                body: callbackData.body,
                auth: callbackData.auth,
                callbackSuccess: callbackData.callbackSuccess,
                callbackError: callbackData.callbackError,
                tokenRefreshed: true
            });
        }
        else if (callbackSuccess !== null) {
            if (callbackData !== null)
                callbackSuccess(callbackData);
            else
                callbackSuccess(result);
        }
        else {
            conLog("callbackSuccess function is null; XHR response is:");
            conLog(result);
        }
    };

    xhr.onerror = () => {
        conError("Network error.");
        alert("There was a network error.");
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    if (auth)
        xhr.setRequestHeader("Authorization", `Bearer ${currentUser.accessToken}`);

    if (body !== null)
        xhr.send(JSON.stringify(body));
    else
        xhr.send();
}