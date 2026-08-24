document.addEventListener("DOMContentLoaded", (event) => {
    setLoginUser(3);

    //ajax();

    if (!loadUser()) {
        showLoginBar();
    }
});


