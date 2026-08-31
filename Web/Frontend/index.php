<!DOCTYPE html>
<html lang="hu">

<?php
/*
#Source:
http://127.0.0.1/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/index.php

With debug:
http://127.0.0.1/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/index.php?debug=517e498b4ae834bca6b046324f226bf4fcea1ee4


On Android:

#Source:
http://0.0.0.0:8080/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/index.php

With debug:
http://0.0.0.0:8080/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/index.php?debug=517e498b4ae834bca6b046324f226bf4fcea1ee42

*/
    class g {
        public static $t;
        public static $URLv;

        public static function init(): void {
            self::$t = time();
            self::$URLv = "?v=".self::$t;
        }
    }
    g::init();

    const DEBUG_TOKEN_PC = "517e498b4ae834bca6b046324f226bf4fcea1ee4";
    const DEBUG_TOKEN_ANDROID = "517e498b4ae834bca6b046324f226bf4fcea1ee42";

    const DEBUG_PC = 1;
    const DEBUG_ANDROID = 2;

    $debug = 0;
    if (isset($_GET["debug"])) {
        if ($_GET["debug"] == DEBUG_TOKEN_PC)
            $debug = DEBUG_PC;
        else if ($_GET["debug"] == DEBUG_TOKEN_ANDROID)
            $debug = DEBUG_ANDROID;
    }
?>

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">
        <meta name="description" content="HTML template practice">
        <meta name="theme-color" content="#ffffff">
        <link rel="icon" type="image/x-icon" href="img/organic/budgetbrain_logo_16x16.png">
        <link rel="stylesheet" type="text/css" href="css/style.css">

<?php
if ($debug == DEBUG_ANDROID)
        echo '<script type="text/javascript" src="external/mobile-console-main_v2/hnl.mobileconsole.min.js"></script>';
?>

        <script type="text/javascript" src="js/endpoints/fn_ajax.js<?= g::$URLv ?>" defer></script>

        <script type="text/javascript" src="js/endpoints/auth/auth-login.js" defer></script>
        <script type="text/javascript" src="js/endpoints/auth/auth-logout.js" defer></script>
        <script type="text/javascript" src="js/endpoints/auth/auth-refresh-token.js" defer></script>
        <script type="text/javascript" src="js/endpoints/auth/auth-registration.js" defer></script>

        <script type="text/javascript" src="js/endpoints/categories/categories-add.js" defer></script>
        <script type="text/javascript" src="js/endpoints/categories/categories-all.js" defer></script>
        <script type="text/javascript" src="js/endpoints/categories/categories-status.js" defer></script>
        <script type="text/javascript" src="js/endpoints/categories/categories-update.js" defer></script>

        <script type="text/javascript" src="js/endpoints/entries/entries-add.js" defer></script>
        <script type="text/javascript" src="js/endpoints/entries/entries-complete.js" defer></script>
        <script type="text/javascript" src="js/endpoints/entries/entries-delete.js" defer></script>
        <script type="text/javascript" src="js/endpoints/entries/entries-get-for-month.js" defer></script>
        <script type="text/javascript" src="js/endpoints/entries/entries-get.js" defer></script>
        <script type="text/javascript" src="js/endpoints/entries/entries-update.js" defer></script>

        <script type="text/javascript" src="js/endpoints/planned-entries/planned-entries-add.js" defer></script>
        <script type="text/javascript" src="js/endpoints/planned-entries/planned-entries-all.js" defer></script>
        <script type="text/javascript" src="js/endpoints/planned-entries/planned-entries-status.js" defer></script>

        <script type="text/javascript" src="js/storage/cookies.js" defer></script>
        <script type="text/javascript" src="js/storage/local-storage.js" defer></script>

        <script type="text/javascript" src="js/constants-global.js" defer></script>
        <script type="text/javascript" src="js/copy-to-clipboard.js" defer></script>
        <script type="text/javascript" src="js/dom-content-loaded.js" defer></script>
        <script type="text/javascript" src="js/mix.js" defer></script>
        <script type="text/javascript" src="js/test-users.js" defer></script>
        <script type="text/javascript" src="js/variables-elements.js" defer></script>
        <script type="text/javascript" src="js/variables-global.js" defer></script>

        <title>BudgetBrain - Budge Your Brain!</title>
    </head>

    <body>
        <header>
            <div>BudgetBrain</div>
            <div><img src="img/organic/budgetbrain_logo_256x256.png" id="id_headerLogo"></div>
        </header>

        <nav>
            <div id="id_div_notLoggedIn">
                <div id="id_div_LoginRegClickable" onclick="showLoginRegister()">Login/Register</div>
            </div>
            <div id="id_div_loggedIn">
                <div>Logged in: <span id="id_sp_name"></span> | ID: <span id="id_sp_id"></span></div>
                <div>Menu 1</div>
                <div>Menu 2</div>
                <div>Menu 3</div>
                <div>Menu 4</div>
                <div>Menu 5</div>
                <div onclick="logout()">Logout</div>
            </div>
        </nav>
        <main>

            <?php if ($debug) require_once("debug/debug.php"); ?>

        </main>

        <footer></footer>

    </body>
</html>