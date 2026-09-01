/*
"registration": {
    "route": "POST /api/auth/registration",
    "body": {
        "username": "username",
        "email": "email",
        "password": "password"
    },
    "response": {
        "message": "Registration successful",
        "userid": "userId"
    }
}
*/

function registration(body) {
    ajax({
        method: "POST",
        url: `${API_PATH}/auth/registration`,
        body: body,
        auth: false,
        callbackSuccess: registrationSuccess,
        callbackError: registrationError
    });
}

/******************************/
/******************************/
/******************************/

function registrationSuccess(result) {
    console.log(result);
    alert("Sikeres regisztráció!");

    if (debug != 0) {
        currentUser.name = e_in_dbgApi_reg_userName.value;
        e_in_dbgApi_authLogin_userName.value = e_in_dbgApi_reg_userName.value;
        e_in_dbgApi_authLogin_password.value = e_in_dbgApi_reg_password.value;
    }

    //loginDirect();
}

/******************************/
/******************************/
/******************************/

function registrationError(result) {
    console.error(result);
    alert("Regisztráció sikertelen!\nFelhasználói név vagy e-mail cím már foglalt.");
}
