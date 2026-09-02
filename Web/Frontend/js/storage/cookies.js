
/******************************/
/******************************/
/******************************/

function getCookies() {
    /*conLog(`document.cookie:`);
    conLog(document.cookie);*/

    let cookies = {};

    if (document.cookie != "") {
        let cook = document.cookie.split(";");

        /*conLog(`cook:`);
        conLog(cook);*/

        for (let i = 0; i < cook.length; i++) {
            cook[i] = cook[i].trimStart().split("=");
            cookies[cook[i][0]] = decodeURIComponent(cook[i][1]);
        }
    }

    /*conLog("cookies:");
    conLog(cookies);*/

    return cookies;
}

/******************************/
/******************************/
/******************************/

function setCookie(name, value, expLengthDays = undefined) {
    let cookieString;

    if (typeof expLengthDays !== "undefined") {
        const d = new Date();
        //conLog(`d.getTime(): ${d.getTime()}`);
        d.setTime(d.getTime() + (expLengthDays*24*60*60*1000));
        //conLog(`d.getTime(): ${d.getTime()}`);
        let expires = `expires=${d.toUTCString()}`;
        cookieString = `${name}=${encodeURIComponent(value)};${expires};path=/`;
    }
    else
        cookieString = `${name}=${encodeURIComponent(value)};path=/`;

    //conLog(`cookieString: ${cookieString}`);
    document.cookie = cookieString;
}

/******************************/
/******************************/
/******************************/
