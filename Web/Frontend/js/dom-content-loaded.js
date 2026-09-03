document.addEventListener("DOMContentLoaded", (event) => {

    cookies = getCookies();

    //fetchLanguage();
    fetchLanguage("hu");

    if (isDebug()) {
        e_menu_container.addEventListener("mouseenter", () => {
            mouseOverDebugMenu = true;
            //conLog("Over");
        });
        e_menu_container.addEventListener("mouseleave", () => {
            mouseOverDebugMenu = false;
            //conLog("Not over");
        });

        setLoginUser(6);
    }
    else {
        e_menu_container.style.display = "none";
    }

    window.addEventListener("resize", () => {
        if (screenSaverEnabled)
            bootAnimation();
    });

    showPage("id_div_page_login", "id_bkg_login");

});


