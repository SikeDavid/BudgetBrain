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
    $isDebug = false;
    if (isset($_GET["debug"])) {
        if ($_GET["debug"] == DEBUG_TOKEN_PC)
            $debug = DEBUG_PC;
        else if ($_GET["debug"] == DEBUG_TOKEN_ANDROID)
            $debug = DEBUG_ANDROID;
    }
    if ($debug!=0)
        $isDebug = true;

    require_once("php/mix.php");
?>

    <?php require_once("php/html-pieces/html-head.php"); ?>

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

            <?php require_once("php/html-pieces/screensaver.php"); ?>
            <?php require_once("php/html-pieces/sidebar.php"); ?>
            <?php require_once("php/html-pieces/backgrounds.php"); ?>
            <?php require_once("php/html-pieces/pages.php"); ?>

<!--
            <div>
                <canvas id="id_chartTest"></chart>
            </div>
-->
        </main>

        <!--<footer></footer>-->

    </body>
</html>