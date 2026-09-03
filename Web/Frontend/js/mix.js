
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

function loginDirect() {
    if (isDebug())
    e_login_userName.value = e_reg_userName.value;
    e_login_password.value = e_reg_password.value;
    login();
}

/******************************/
/******************************/
/******************************/

function conLog(data) {
    if (debug!=0) console.log(data);
}

/******************************/
/******************************/
/******************************/

function conError(data) {
    if (debug!=0) console.error(data);
}

/******************************/
/******************************/
/******************************/

function msTime(str) {
    let errorValue = null;

    str = str.replace(/\s/g, "");

    const units = {
        h:  60 * 60 * 1000,
        m:  60 * 1000,
        s:  1000,
        ms: 1
    };

    const regex = /(\d+(?:\.\d+)?)(ms|h|m|s)/g;

    let total = 0;
    let used = new Set();
    let position = 0;
    let match;

    while ((match = regex.exec(str)) !== null) {
        if (match.index !== position)
            return errorValue;

        const value = Number(match[1]);
        const unit = match[2];

        if (used.has(unit))
            return errorValue;

        used.add(unit);
        total += value * units[unit];

        position = regex.lastIndex;
    }

    return position === str.length ? total : null;
}

/******************************/
/******************************/
/******************************/

function isDebug () {
    let state = false;
    if (debug != null && debug != 0)
        state = true;
    return state;
}

/******************************/
/******************************/
/******************************/

function showPage(pg_id, bkg_id) {

    document.querySelectorAll(".cl_page").forEach(page => {
        page.classList.remove("active");
    });

    document.querySelectorAll(".cl_background").forEach(background => {
        background.classList.remove("active");
    });

    if (pg_id != null)
        document.getElementById(pg_id).classList.add("active");

    if (bkg_id != null)
        document.getElementById(bkg_id).classList.add("active");
}

/******************************/
/******************************/
/******************************/
