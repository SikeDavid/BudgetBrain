
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
    const xhr = new XMLHttpRequest();
    xhr.open("POST", `${API_PATH}/auth/refreshtoken`);

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            let response = JSON.parse(xhr.responseText);
            console.error(response);
            return false;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
        currentUser.accessToken = response.accessToken;
        e_accessToken.value = response.accessToken;

        return true;
    };

    xhr.onerror = () => {
        console.error("Network error.");
        return false;
    };

    xhr.setRequestHeader("Content-Type", "application/json");

    const body = {
        "refreshToken": currentUser.refreshToken
    };

    xhr.send(JSON.stringify(body));

    return true;
}

/******************************/
/******************************/
/******************************/

function refreshTokenSuccess(response) {

}

/******************************/
/******************************/
/******************************/

function refreshTokenError(response) {

}

