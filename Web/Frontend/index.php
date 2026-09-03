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

    <head>
        <meta charset="UTF-8">
        <meta http-equiv="Cache-Control" content="no-cache, no-store, must-revalidate">
        <meta http-equiv="Pragma" content="no-cache">
        <meta http-equiv="Expires" content="0">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">
        <meta name="description" content="HTML template practice">
        <meta name="theme-color" content="#ffffff">
        <link rel="icon" type="image/x-icon" href="img/organic/budgetbrain_logo_16x16.png">

        <?php
            loadCSSFiles();

            if ($debug == DEBUG_ANDROID)
                echo '<script type="text/javascript" src="thirdparty/mobile-console-main_v2/hnl.mobileconsole.min.js"></script>';

            echo "<script>const debug = ".json_encode($debug).";</script>";

            loadJavaScriptFiles();
        ?>

        <script type="text/javascript" src="thirdparty/chart-js/chart.umd.min.js"></script>

        <title>BudgetBrain - Budge Your Brain!</title>
    </head>

    <body>

        <div id="id_div_screensaverContainer">
            <div id="id_menu_container">
                <div onclick="startAnimation()">[Start animation]</div>
                <div onclick="step()">[Step frame]</div>
                <div onclick="stopAnimation()">[Stop animation]</div>
                <div onclick="debugStop()">[Debug stop]</div>
                <div onclick="toggleDebugMask()">[Toggle debug mask]</div>
                <div id="id_frameLengthSet">
                    <div>Frame length: </div>
                    <input type="number" step="1" min="0" id="id_input_text_frame_length">
                    <div onclick="setTimeFrameLength()">[Set]</div>
                </div>
            </div>
            <div id="id_screen_a"></div>
            <div id="id_screen_b"></div>
            <div id="id_screen_c"></div>
            <div id="id_debugMask"></div>
            <div id="id_crtScreenMask"></div>
            <img src="img/crt_screen_mask.png" width="792" height="576">
        </div>

        <!--<header>
            <div>BudgetBrain</div>
            <div><img src="img/organic/budgetbrain_logo_256x256.png" id="id_headerLogo"></div>
        </header>-->

        <main>

            <div id="id_div_languageSelector">
                <img src="img/flag/hu.svg" onclick="fetchLanguage('hu')" class="cl_flagImage">
                <img src="img/flag/en.svg" onclick="fetchLanguage('en')" class="cl_flagImage">
            </div>

            <aside id="id_sec_sidebar">
                <?php require_once("php/sidebar.php"); ?>
            </aside>


            <div id="id_bkg_login" class="cl_background"></div>
            <div id="id_bkg_register" class="cl_background"></div>
            <div id="id_bkg_user" class="cl_background"></div>
            <div id="id_bkg_income" class="cl_background"></div>
            <div id="id_bkg_expenses" class="cl_background"></div>
            <div id="id_bkg_statistics" class="cl_background"></div>
            <div id="id_bkg_savings" class="cl_background"></div>
            <div id="id_bkg_settings" class="cl_background"></div>
            <div id="id_bkg_logout" class="cl_background"></div>

            <section id="id_sec_pages">
                <?php require_once("php/pages/pg_home.php"); ?>
                <?php require_once("php/pages/pg_login.php"); ?>
                <?php require_once("php/pages/pg_register.php"); ?>
                <?php require_once("php/pages/pg_user.php"); ?>
                <?php require_once("php/pages/pg_income.php"); ?>
                <?php require_once("php/pages/pg_expenses.php"); ?>
                <?php require_once("php/pages/pg_statistics.php"); ?>
                <?php require_once("php/pages/pg_savings.php"); ?>
                <?php require_once("php/pages/pg_settings.php"); ?>
                <?php if ($isDebug) require_once("php/pages/pg_debug.php"); ?>
                <?php require_once("php/pages/pg_logout.php"); ?>
            </section>
<!--
            <div>
                <canvas id="id_chartTest"></chart>
            </div>
-->
        </main>

        <!--<footer></footer>-->

    </body>
</html>