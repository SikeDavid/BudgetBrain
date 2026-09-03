
async function inputCopyToClipboard(element) {
    await navigator.clipboard.writeText(element.value);
}

/******************************/
/******************************/
/******************************/

async function innerHTMLCopyToClipboard(element) {
    await navigator.clipboard.writeText(element.innerHTML);
}


