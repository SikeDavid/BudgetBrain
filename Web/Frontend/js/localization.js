
/******************************/
/******************************/
/******************************/

function t(key) {
    return lclTxt[key] ?? key;
}

/******************************/
/******************************/
/******************************/

function localizePage() {
    document.querySelectorAll("[data-l10n]").forEach(element => {
        element.textContent = t(element.dataset.l10n);
    });

    document.querySelectorAll("[data-l10n-placeholder]").forEach(element => {
        element.placeholder = t(element.dataset.l10nPlaceholder);
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
        console.log("Result:");
        console.log(result);
        if (lang != "") {
            lclTxt = result.data;
            localizePage();
            console.log(lclTxt);
        }
        else
            languages = result;
    } catch (error) {
        console.error("Fetch error:");
        console.error(error.message);
    }
}
