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

function registration() {
    const body = {
        "username": e_reg_userName.value,
        "email": e_reg_email.value,
        "password": e_reg_password.value
    };

    ajax({
        caller: registration,
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

function registrationSuccess(response) {
    alert("Sikeres regisztráció!");
    //currentUser.id = ;
    currentUser.name = e_reg_userName;
    //loginDirect();
}

/******************************/
/******************************/
/******************************/

function registrationError(response) {
    alert("Regisztráció sikertelen!\nFelhasználói név vagy e-mail cím már foglalt.");
}
