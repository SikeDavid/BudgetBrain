
/******************************/
/******************************/
/******************************/

function translate(key) {
    if (lclTxt[key] == null)
        conError("Cannot find localization data for element-key: " + key);
    return lclTxt[key] ?? key;
}

/******************************/
/******************************/
/******************************/

function localizePage() {
    document.querySelectorAll("[data-l10n]").forEach(element => {
        element.textContent = translate(element.dataset.l10n);
    });

    document.querySelectorAll("[data-l10n-placeholder]").forEach(element => {
        element.placeholder = translate(element.dataset.l10nPlaceholder);
    });
}

/******************************/
/******************************/
/******************************/

function setLanguage() {

}

/******************************/
/******************************/
/******************************/

function getLanguage() {
    //userSelectedLanguage = "";
}

/******************************/
/******************************/
/******************************/

async function fetchLanguage(lang) {
    if (lang == null)
        lang = "";
    const url = `backend/languages/${lang}`;
    try {
        const response = await fetch(url);
        if (!response.ok) {
            throw new Error(`Response status: ${response.status}`);
        }
        const result = await response.json();
        conLog("Result:");
        conLog(result);
        if (lang != "") {
            lclTxt = result.data;
            localizePage();
            conLog(lclTxt);
        }
        else
            languages = result;
    } catch (error) {
        conError("Fetch error:");
        conError(error.message);
    }
}
