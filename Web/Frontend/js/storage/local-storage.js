
/******************************/
/******************************/
/******************************/

function loadUser() {
    let rawData = JSON.parse(localStorage.getItem("userData"));

    if (isObject(rawData)) {
        currentUser = correctUserData(rawData);
        if (currentUser == false) {
            clearUser();
            return false;
        }
        return true;
    }
    else {
        clearUser();
        return false;
    }
}

/******************************/
/******************************/
/******************************/

function saveUser() {
    localStorage.setItem("userData", JSON.stringify(currentUser));
}

/******************************/
/******************************/
/******************************/
