
function ajax({method = "GET", url = `${PROTOCOL}://${API_HOST}:${API_PORT}`, body = {}, auth = false, callbackSuccess = null, callbackError = null} = {}) {
    const xhr = new XMLHttpRequest();
    xhr.open(method, url);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            if (callbackError !== null)
                callbackError(response);
            else
                console.log("callbackError is null");
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
        if (callbackSuccess !== null)
            callbackSuccess(response);
        else
            console.log("callbackSuccess is null");
        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        alert("There was a network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    if (auth)
        xhr.setRequestHeader("Authorization", `Bearer ${currentUser.accessToken}`);

    if (body !== {})
        xhr.send(JSON.stringify(body));
    else
        xhr.send();

    return true;
}
