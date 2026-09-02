
let inactivityTimer;
let screensaveOn = false;
let mouseOverDebugMenu = false;

[
    "mousemove",
    "mousedown",
    "mouseup",
    "keydown",
    "keyup",
    "touchstart",
    "scroll"
].forEach(event => {
    document.addEventListener(event, resetInactivityTimer);
});

resetInactivityTimer();

/******************************/
/******************************/
/******************************/

function resetInactivityTimer() {
    clearTimeout(inactivityTimer);

    if (screensaveOn && !mouseOverDebugMenu)
        stopScreensaver();

    inactivityTimer = setTimeout(() => {
        if (screenSaverEnabled)
            startScreensaver();
    }, screensaverTime);
}

/******************************/
/******************************/
/******************************/

function startScreensaver() {
    //conLog("Screensaver starting!");
    screensaveOn = true;
    e_div_screensaverContainer.classList.add("active");
    bootAnimation();
}

/******************************/
/******************************/
/******************************/

function stopScreensaver() {
    //conLog("Screensaver stopping!");
    screensaveOn = false;
    e_div_screensaverContainer.classList.remove("active");
    stopAnimation();
}

/******************************/
/******************************/
/******************************/

