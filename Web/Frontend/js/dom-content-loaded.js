document.addEventListener("DOMContentLoaded", (event) => {
    if (debug != 0)
        setLoginUser(6);

    cookies = getCookies();

    //fetchLanguage();
    fetchLanguage("hu");

});


