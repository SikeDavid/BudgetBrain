function ajax({
        caller = null,
        method = "GET",
        url = `${PROTOCOL}://${API_HOST}:${API_PORT}`,
        body = null,
        auth = false,
        callbackSuccess = null,
        callbackError = null,
        callbackData = null,
        tokenRefreshed = false
    } = {}) {

    if (caller === null) {
        console.error('Parameter "caller" isn\'t provided in "ajax()" call!');
        return;
    }

    const xhr = new XMLHttpRequest();
    xhr.open(method, url);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);

            if (xhr.status == 500) {
                /*>
                    > tokenRefreshed = true -> Theoretical possibility / Edge case: The second non-refreshToken ajax call on a go. Preventing infinite loop: if a token is refreshed but expires by the time we receive it.
                    > response.message == "jwt malformed" -> illegal / nonexisting accessToken
                    > In these cases -> Logout
                <*/
                if (tokenRefreshed || response.message == "jwt malformed") {
                    refreshTokenError(response);
                    return;
                }
                //> AccessToken expired, refreshing:
                if (response.message == "jwt expired") {
                    console.error(response);
                    console.error("AccessToken expired, refreshing...");
                    const body = {
                        "refreshToken": currentUser.refreshToken
                    };

                    ajax({
                        caller: ajax,
                        method: "POST",
                        url: `${API_PATH}/auth/refreshtoken`,
                        body: body,
                        auth: false,
                        callbackSuccess: refreshTokenSuccess,
                        callbackError: refreshTokenError,
                        callbackData: {
                            caller: caller,
                            method: method,
                            url: url,
                            body: body,
                            auth: auth,
                            callbackSuccess: callbackSuccess,
                            callbackError: callbackError
                        }
                    });
                }
                else {
                    console.error("Unhandled server error.");
                }
            }

            else if (callbackError !== null)
                callbackError(response);
            else {
                console.log("callbackError function is null; XHR response is:");
                console.error(response);
            }
            return;
        }

        let response = JSON.parse(xhr.responseText);

        if (callbackData !== null) {
            console.log("Token refresh successful!");
            callbackSuccess(response);
            ajax({
                caller: callbackData.caller,
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
                callbackSuccess(response);
        }
        else {
            console.log("callbackSuccess function is null; XHR response is:");
            console.log(response);
        }
    };

    xhr.onerror = () => {
        console.error("Network error.");
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