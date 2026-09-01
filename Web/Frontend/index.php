<!DOCTYPE html>
<html lang="hu-HU">

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
    const BR = "<br>";
    const NS = "&nbsp;";
    const HTML_TAB = NS.NS.NS.NS;
    const LF = "\n";
    const CR = "\r";
    const TAB = "\t";

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

    require_once("php/mix.php");
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
            echo "<script>const debug = ".json_encode($debug).";</script>";
            loadJavaScriptFiles();
        ?>

        <script type="text/javascript" src="external/chart-js/chart.umd.min.js"></script>

        <title>BudgetBrain - Budge Your Brain!</title>
    </head>

    <body>
        <!--<header>
            <div>BudgetBrain</div>
            <div><img src="img/organic/budgetbrain_logo_256x256.png" id="id_headerLogo"></div>
        </header>-->

        <main>

            <div id="id_div_languageSelector">
                <img src="img/flag/hu.svg" onclick="fetchLanguage('hu')" class="cl_flagImage">
                <img src="img/flag/en.svg" onclick="fetchLanguage('en')" class="cl_flagImage">
            </div>

            <div><input type="date"></div>

            <div data-l10n="div.test1">Placeholder</div>
            <div data-l10n="div.test2">Placeholder</div>

            <?php if ($debug) require_once("debug/debug.php"); ?>

            <div>
                <canvas id="id_chartTest"></chart>
            </div>

        </main>

        <footer></footer>

    </body>
</html>