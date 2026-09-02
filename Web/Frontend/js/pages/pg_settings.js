
document.getElementById("id_in_pgSet_screensaverDuration").addEventListener("beforeinput", function (e) {
    console.log(e.data);
    if (e.data == 7) {
        e.preventDefault();
        //e.stopPropagation();
    }
});
document.getElementById("id_in_pgSet_screensaverDuration").addEventListener("input", e => {
    console.log(e.data);
});

//let screensaverTime = msTime("5m");
let screensaverTime = msTime("1s");

let screenSaverEnabled = false;
