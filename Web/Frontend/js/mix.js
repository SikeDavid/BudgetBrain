
/******************************/
/******************************/
/******************************/

function isObject(obj) {
    return (
        typeof obj === "object" &&
        !Array.isArray(obj) &&
        obj !== null
    );
}

/******************************/
/******************************/
/******************************/

function deepCopy(v) {
    return JSON.parse(JSON.stringify(v));
}

/******************************/
/******************************/
/******************************/

function clearUser() {
    currentUser = deepCopy(nullUser);
}

/******************************/
/******************************/
/******************************/

function correctUserData(usrDta) {
    if (
        usrDta.id == null ||
        usrDta.name == null ||
        usrDta.refreshToken == null ||
        usrDta.accessToken == null
    ) {
        return false;
    }

    return {
        "id": usrDta.id,
        "name": usrDta.name,
        "refreshToken": usrDta.refreshToken,
        "accessToken": usrDta.accessToken
    }
}

/******************************/
/******************************/
/******************************/

function showSection(el) {
    for (let i = 0; i < sections.length; i++) {
        sections[i].style.display = "none";
    }
    el.style.display = "block";
}

/******************************/
/******************************/
/******************************/

function loginDirect() {
    e_login_userName.value = e_reg_userName.value;
    e_login_password.value = e_reg_password.value;
    login();
}

/******************************/
/******************************/
/******************************/
