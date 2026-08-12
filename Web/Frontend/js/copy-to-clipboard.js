
async function copyTokens() {
    await navigator.clipboard.writeText(`Access token:\n${e_login_accessToken.value}\n\nRefresh token:\n${e_login_refreshToken.value}`);
}

/******************************/
/******************************/
/******************************/

async function inputCopyToClipboard(element) {
    await navigator.clipboard.writeText(element.value);
}

/******************************/
/******************************/
/******************************/

async function innerHTMLCopyToClipboard(element) {
    await navigator.clipboard.writeText(element.innerHTML);
}


