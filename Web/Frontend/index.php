<!DOCTYPE html>
<html lang="hu">
<!--
http://127.0.0.1/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/index.php

-->
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">
        <meta name="description" content="HTML template practice">
        <meta name="theme-color" content="#ffffff">
        <link rel="icon" type="image/x-icon" href="img/organic/budgetbrain_logo_16x16.png">
        <link rel="stylesheet" type="text/css" href="css/style.css">

        <script type="text/javascript" src="js/endpoints/ajax.js" defer></script>
        <script type="text/javascript" src="js/endpoints/auth.js" defer></script>
        <script type="text/javascript" src="js/endpoints/categories.js" defer></script>
        <script type="text/javascript" src="js/endpoints/entries.js" defer></script>
        <script type="text/javascript" src="js/endpoints/planned-entries.js" defer></script>

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
                <div id="id_div_LoginRegClickable" onclick="showLoginRegiser()">Login/Register</div>
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
            <section id="id_sec_logReg" style="display:none">
                <button onclick="registration()">Registration</button>
                <br>
                <input id="id_reg_userName" value="TestUser01">
                <br>
                <input id="id_reg_email" value="testuser01@email.com">
                <br>
                <input id="id_reg_password" value="Password01!">
                <br>
                <br>
                <button onclick="login()">Login</button>
                <br>
                <input id="id_login_userName" value="TestUser01">
                <br>
                <input id="id_login_password" type="password" value="Password01!">
                <br>
                <input id="id_login_accessToken" placeholder="Access token" readonly>
                <br>
                <input id="id_login_refreshToken" placeholder="Refresh token" readonly>
                <br>
                <button onclick="copyTokens()">Copy tokens to Clipboard</button>
            </section>

            <section id="id_sec_test" style="display:block">
                <button onclick="refreshDaToken()">Refresh token</button>
                <br>
                <input id="id_accessToken" placeholder="Access token" readonly>
                <br>
                <br>
                <button onclick="categoriesAll()">Categories - All</button>
                <br>
                <button onclick="categoriesAdd()">Categories - Add</button>
                <br>
                <button onclick="categoriesUpdate(10)">Categories - Update</button>
                <br>
                <button onclick="categoriesStatus(10)">Categories - Status</button>
                <br>
                <br>
                <button onclick="entriesGet(4)">Entries - Get</button>
                <br>
                <button onclick="entriesGetForMonth(2026, 4)">Entries - Get for month</button>
                <br>
                <button onclick="entriesAdd()">Entries - Add</button>
                <br>
                <button onclick="entriesUpdate(20)">Entries - Update</button>
                <br>
                <button onclick="entriesComplete(20)">Entries - Complete</button>
                <br>
                <button onclick="entriesDelete(20)">Entries - Delete</button>
                <br>
                <br>
                <button onclick="plannedEntriesAll()">Planned Entries - Get All</button>
                <br>
                <button onclick="plannedEntriesAdd()">Planned Entries - Add</button>
                <br>
                <button onclick="plannedEntriesStatus(9)">Planned Entries - Status</button>
            </section>
        </main>

        <footer></footer>

    </body>
</html>