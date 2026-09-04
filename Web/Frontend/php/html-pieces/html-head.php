
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
