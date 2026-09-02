<?php
    $testUser = [
        "name" => "BitMiller",
        "email" => "bitmiller@test.com",
        "password" => "Almafa123-"
    ];
?>
<script>
    const testUser = <?= json_encode($testUser); ?>;
    //conLog(testUser);
</script>

<div id="id_div_page_debug" class="cl_page" style="background-color: white;">
    <div id="id_div_debugContainer">
        <hr>
        <h3>Auth:</h3>
        <hr>

    <!--=====================================-->
    <!-- ENDPOINT COLLECTION: Auth -->
    <!--=====================================-->

    <!-- ELEMENT COLLECTION: Registration -->
        <button id="id_btn_dbgApi_auth_reg">Registration</button>
        <br>
        <input id="id_in_dbgApi_authReg_userName" value="TestUser01">
        <br>
        <input id="id_in_dbgApi_authReg_email" value="testuser01@email.com">
        <br>
        <input id="id_in_dbgApi_authReg_password" value="Password01!">

        <hr>

    <!-- ELEMENT COLLECTION: Login -->
        <button id="id_btn_dbgApi_auth_login">Login</button>
        <br>
        <input id="id_in_dbgApi_authLogin_userName" value="TestUser01">
        <br>
        <input id="id_in_dbgApi_authLogin_password" type="password" value="Password01!">
        <br>
        <input id="id_in_dbgApi_authLogin_accessToken" placeholder="Access token" readonly>
        <br>
        <input id="id_in_dbgApi_authLogin_refreshToken" placeholder="Refresh token" readonly>
        <br>
        <button onclick="copyTokens()">Copy tokens to Clipboard</button>

        <hr>

    <!-- ELEMENT COLLECTION: Refresh token -->
        <button id="id_btn_dbgApi_auth_refresh">Refresh token</button>
        <br>
        <input id="id_in_dbgApi_authRefresh_accessToken" placeholder="Access token" readonly>

        <hr>

    <!-- ELEMENT COLLECTION: Logout -->
        <button id="id_btn_dbgApi_auth_logout">Logout</button>

        <hr>
        <hr>
        <h3>Categories:</h3>
        <hr>

    <!--=====================================-->
    <!-- ENDPOINT COLLECTION: Categories -->
    <!--=====================================-->

    <!-- ELEMENT COLLECTION: Categories Get all -->
        <button id="id_btn_dbgApi_cat_all">Categories - All</button>

        <hr>

    <!-- ELEMENT COLLECTION: Category Add -->
        <button id="id_btn_dbgApi_cat_add">Categories - Add</button>
        <br>
        <input id="id_in_dbgApi_catAdd_name" placeholder="Category name">
        <br>
        <label for="id_sel_dbgApi_catAdd_item">Item type:</label>
        <br>
        <select id="id_sel_dbgApi_catAdd_item" name="id_sel_dbgApi_catAdd_item">
            <option value="income">Income</option>
            <option value="expense">Expense</option>
        </select>
        <br>
        <label for="id_cbx_dbgApi_catAdd_inUse">In use:</label>
        <input type="checkbox" id="id_cbx_dbgApi_catAdd_inUse" name="id_cbx_dbgApi_catAdd_inUse" checked>

        <hr>

    <!-- ELEMENT COLLECTION: Category Update -->
        <button id="id_btn_dbgApi_cat_up">Categories - Update</button>
        <br>
        <input id="id_in_dbgApi_catUp_id" type="number" placeholder="Category ID" value="7">
        <br>
        <input id="id_in_dbgApi_catUp_name" placeholder="Category name">
        <br>
        <label for="id_sel_dbgApi_catUp_item">Item type:</label>
        <br>
        <select id="id_sel_dbgApi_catUp_item" name="id_sel_dbgApi_catUp_item">
            <option value="income">Income</option>
            <option value="expense">Expense</option>
        </select>
        <br>
        <label for="id_cbx_dbgApi_catUp_inUse">In use:</label>
        <input type="checkbox" id="id_cbx_dbgApi_catUp_inUse" name="id_cbx_dbgApi_catUp_inUse" checked>

        <hr>

    <!-- ELEMENT COLLECTION: Category Status -->
        <button id="id_btn_dbgApi_cat_stat">Categories - Status</button>
        <br>
        <input id="id_in_dbgApi_catStat_id" type="number" placeholder="Category ID" value="7">

        <hr>
        <hr>
        <h3>Entries:</h3>
        <hr>

    <!--=====================================-->
    <!-- ENDPOINT COLLECTION: Entries -->
    <!--=====================================-->

    <!-- ELEMENT COLLECTION: Entries Get by ID -->
        <button id="id_btn_dbgApi_ent_get">Entries - Get by ID</button>
        <br>
        <input id="id_in_dbgApi_entGet_id" type="number" placeholder="ID" value="11">

        <hr>

    <!-- ELEMENT COLLECTION: Entries Get for month -->
        <button id="id_btn_dbgApi_ent_getM">Entries - Get for month</button>
        <br>
        <input id="id_in_dbgApi_entGetY" type="number" placeholder="Year" value="2026">
        <br>
        <input id="id_in_dbgApi_entGetM" type="number" placeholder="Month" value="4">

        <hr>

    <!-- ELEMENT COLLECTION: Entry Add -->
        <button id="id_btn_dbgApi_ent_add">Entries - Add</button>
        <br>
        <input id="id_in_dbgApi_entAdd_catId" type="number" placeholder="Category ID" value="7">
        <br>
        <input id="id_in_dbgApi_entAdd_amt" type="number" placeholder="Amount" value="1000">
        <br>
        <input id="id_in_dbgApi_entAdd_desc" placeholder="Description" value="Some basic text.">
        <br>
        <input id="id_in_dbgApi_entAdd_date" placeholder="Date" value="2026-04-01">

        <hr>

    <!-- ELEMENT COLLECTION: Entry Update -->
        <button id="id_btn_dbgApi_ent_up">Entries - Update</button>
        <br>
        <input id="id_in_dbgApi_entUp_entId" type="number" placeholder="Entry ID" value="11">
        <br>
        <input id="id_in_dbgApi_entUp_catId" type="number" placeholder="Category ID" value="7">
        <br>
        <input id="id_in_dbgApi_entUp_name" placeholder="Category name" value="Fizetés">
        <br>
        <input id="id_in_dbgApi_entUp_amt" type="number" placeholder="Amount" value="2000">
        <br>
        <input id="id_in_dbgApi_entUp_desc" placeholder="Description" value="Some basic text as well.">
        <br>
        <input id="id_in_dbgApi_entUp_date" placeholder="Date" value="2026-04-02">
        <br>
        <label for="id_cbx_dbgApi_entUp_comp">Completed:</label>
        <input type="checkbox" id="id_cbx_dbgApi_entUp_comp" name="id_cbx_dbgApi_entUp_comp" checked>

        <hr>

    <!-- ELEMENT COLLECTION: Entry Complete -->
        <button id="id_btn_dbgApi_ent_comp">Entries - Complete</button>
        <br>
        <input id="id_in_dbgApi_entComp_entId" type="number" placeholder="Entry ID" value="11">

        <hr>

    <!-- ELEMENT COLLECTION: Entry Delete -->
        <button id="id_btn_dbgApi_ent_del">Entries - Delete</button>
        <br>
        <input id="id_in_dbgApi_entDel_entId" type="number" placeholder="Entry ID" value="11">

        <hr>
        <hr>
        <h3>Planned entries:</h3>
        <hr>

    <!--=====================================-->
    <!-- ENDPOINT COLLECTION: Planned entries -->
    <!--=====================================-->

    <!-- ELEMENT COLLECTION: Planned entries Get all -->
        <button id="id_btn_dbgApi_plEnt_all">Planned Entries - Get All</button>

        <hr>

    <!-- ELEMENT COLLECTION: Planned entry Add -->
        <button id="id_btn_dbgApi_plEnt_add">Planned Entries - Add</button>
        <br>
        <input id="id_in_dbgApi_plEntAdd_catId" type="number" placeholder="Category ID" value="7">
        <br>
        <input id="id_in_dbgApi_plEntAdd_name" placeholder="Name" value="Fizetés">
        <br>
        <input id="id_in_dbgApi_plEntAdd_amt" type="number" placeholder="Amount" value="7000">
        <br>
        <input id="id_in_dbgApi_plEntAdd_dom" type="number" placeholder="Day of month" value="12">

        <hr>

    <!-- ELEMENT COLLECTION: Planned entry Status -->
        <button id="id_btn_dbgApi_plEnt_stat">Planned Entries - Status</button>
        <br>
        <input id="id_in_dbgApi_plEntStat_id" type="number" placeholder="Planned entry ID" value="7">

        <!--<hr>-->
    </div>
</div>

<!--=====================================-->
<!--=====================================-->
<script>
/*========================================*/
/*========================================*/

/*

const e_ = document.getElementById("id_");
*/

/*========================================*/
//> ENDPOINT COLLECTION: Auth
/*========================================*/

/*> ELEMENT COLLECTION: Registration <*/
const e_btn_dbgApi_auth_reg = document.getElementById("id_btn_dbgApi_auth_reg");
const e_in_dbgApi_authReg_userName = document.getElementById("id_in_dbgApi_authReg_userName");
const e_in_dbgApi_authReg_email = document.getElementById("id_in_dbgApi_authReg_email");
const e_in_dbgApi_authReg_password = document.getElementById("id_in_dbgApi_authReg_password");

e_btn_dbgApi_auth_reg.addEventListener("click", () => {
    registration({
        "username": e_in_dbgApi_authReg_userName.value,
        "email": e_in_dbgApi_authReg_email.value,
        "password": e_in_dbgApi_authReg_password.value
    });
});

/*> ELEMENT COLLECTION: Login <*/
const e_btn_dbgApi_auth_login = document.getElementById("id_btn_dbgApi_auth_login");
const e_in_dbgApi_authLogin_userName = document.getElementById("id_in_dbgApi_authLogin_userName");
const e_in_dbgApi_authLogin_password = document.getElementById("id_in_dbgApi_authLogin_password");
const e_in_dbgApi_authLogin_accessToken = document.getElementById("id_in_dbgApi_authLogin_accessToken");
const e_in_dbgApi_authLogin_refreshToken = document.getElementById("id_in_dbgApi_authLogin_refreshToken");

e_btn_dbgApi_auth_login.addEventListener("click", () => {
    login({
        "username": e_in_dbgApi_authLogin_userName.value,
        "password": e_in_dbgApi_authLogin_password.value
    });
});

/*> ELEMENT COLLECTION: Refresh token <*/
const e_btn_dbgApi_auth_refresh = document.getElementById("id_btn_dbgApi_auth_refresh");
const e_in_dbgApi_authRefresh_accessToken = document.getElementById("id_in_dbgApi_authRefresh_accessToken");

e_btn_dbgApi_auth_refresh.addEventListener("click", () => {
    refreshToken({
        "refreshToken": currentUser.refreshToken
    });
});

/*> ELEMENT COLLECTION: Logout <*/
const e_btn_dbgApi_auth_logout = document.getElementById("id_btn_dbgApi_auth_logout");

e_btn_dbgApi_auth_logout.addEventListener("click", () => {
    logout({
        "refreshToken": currentUser.refreshToken
    });
});

/*========================================*/
//> ENDPOINT COLLECTION: Categories
/*========================================*/

/*> ELEMENT COLLECTION: Categories Get all <*/
const e_btn_dbgApi_cat_all = document.getElementById("id_btn_dbgApi_cat_all");

e_btn_dbgApi_cat_all.addEventListener("click", () => {
    categoriesAll();
});

/*> ELEMENT COLLECTION: Category Add <*/
const e_btn_dbgApi_cat_add = document.getElementById("id_btn_dbgApi_cat_add");
const e_in_dbgApi_catAdd_name = document.getElementById("id_in_dbgApi_catAdd_name");
const e_sel_dbgApi_catAdd_item = document.getElementById("id_sel_dbgApi_catAdd_item");
const e_cbx_dbgApi_catAdd_inUse = document.getElementById("id_cbx_dbgApi_catAdd_inUse");

e_btn_dbgApi_cat_add.addEventListener("click", () => {
    categoriesAdd({
        "name": e_in_dbgApi_catAdd_name.value,
        "type": e_sel_dbgApi_catAdd_item.options[e_sel_dbgApi_catAdd_item.selectedIndex].value,
        "in_use": e_cbx_dbgApi_catAdd_inUse.checked ? 1 : 0
    });
});

/*> ELEMENT COLLECTION: Category Update <*/
const e_btn_dbgApi_cat_up = document.getElementById("id_btn_dbgApi_cat_up");
const e_in_dbgApi_catUp_id = document.getElementById("id_in_dbgApi_catUp_id");
const e_in_dbgApi_catUp_name = document.getElementById("id_in_dbgApi_catUp_name");
const e_sel_dbgApi_catUp_item = document.getElementById("id_sel_dbgApi_catUp_item");
const e_cbx_dbgApi_catUp_inUse = document.getElementById("id_cbx_dbgApi_catUp_inUse");

e_btn_dbgApi_cat_up.addEventListener("click", () => {
    categoriesUpdate(e_in_dbgApi_catUp_id.value, {
        "name": e_in_dbgApi_catUp_name.value,
        "type": e_sel_dbgApi_catUp_item.options[e_sel_dbgApi_catUp_item.selectedIndex].value,
        "in_use": e_cbx_dbgApi_catUp_inUse.checked ? 1 : 0
    });
});

/*> ELEMENT COLLECTION: Category Status <*/
const e_btn_dbgApi_cat_stat = document.getElementById("id_btn_dbgApi_cat_stat");
const e_in_dbgApi_catStat_id = document.getElementById("id_in_dbgApi_catStat_id");

e_btn_dbgApi_cat_stat.addEventListener("click", () => {
    categoriesStatus(e_in_dbgApi_catStat_id.value);
});

/*========================================*/
//> ENDPOINT COLLECTION: Entries
/*========================================*/

/*> ELEMENT COLLECTION: Entries Get by ID <*/
const e_btn_dbgApi_ent_get = document.getElementById("id_btn_dbgApi_ent_get");
const e_in_dbgApi_entGet_id = document.getElementById("id_in_dbgApi_entGet_id");

e_btn_dbgApi_ent_get.addEventListener("click", () => {
    entriesGet(e_in_dbgApi_entGet_id.value);
});

/*> ELEMENT COLLECTION: Entries Get for month <*/
const e_btn_dbgApi_ent_getM = document.getElementById("id_btn_dbgApi_ent_getM");
const e_in_dbgApi_entGetY = document.getElementById("id_in_dbgApi_entGetY");
const e_in_dbgApi_entGetM = document.getElementById("id_in_dbgApi_entGetM");

e_btn_dbgApi_ent_getM.addEventListener("click", () => {
    entriesGetForMonth(e_in_dbgApi_entGetY.value, e_in_dbgApi_entGetM.value);
});

/*> ELEMENT COLLECTION: Entry Add <*/
const e_btn_dbgApi_ent_add = document.getElementById("id_btn_dbgApi_ent_add");
const e_in_dbgApi_entAdd_catId = document.getElementById("id_in_dbgApi_entAdd_catId");
const e_in_dbgApi_entAdd_amt = document.getElementById("id_in_dbgApi_entAdd_amt");
const e_in_dbgApi_entAdd_desc = document.getElementById("id_in_dbgApi_entAdd_desc");
const e_in_dbgApi_entAdd_date = document.getElementById("id_in_dbgApi_entAdd_date");

e_btn_dbgApi_ent_add.addEventListener("click", () => {
    entriesAdd({
        "categoryid": e_in_dbgApi_entAdd_catId.value,
        "amount": e_in_dbgApi_entAdd_amt.value,
        "description": e_in_dbgApi_entAdd_desc.value,
        "date": e_in_dbgApi_entAdd_date.value
    });
});

/*> ELEMENT COLLECTION: Entry Update <*/
const e_btn_dbgApi_ent_up = document.getElementById("id_btn_dbgApi_ent_up");
const e_in_dbgApi_entUp_entId = document.getElementById("id_in_dbgApi_entUp_entId");
const e_in_dbgApi_entUp_catId = document.getElementById("id_in_dbgApi_entUp_catId");
const e_in_dbgApi_entUp_name = document.getElementById("id_in_dbgApi_entUp_name");
const e_in_dbgApi_entUp_amt = document.getElementById("id_in_dbgApi_entUp_amt");
const e_in_dbgApi_entUp_desc = document.getElementById("id_in_dbgApi_entUp_desc");
const e_in_dbgApi_entUp_date = document.getElementById("id_in_dbgApi_entUp_date");
const e_cbx_dbgApi_entUp_comp = document.getElementById("id_cbx_dbgApi_entUp_comp");

e_btn_dbgApi_ent_up.addEventListener("click", () => {
    entriesUpdate(e_in_dbgApi_entUp_entId.value, {
        "category_id": e_in_dbgApi_entUp_catId.value,
        "name": e_in_dbgApi_entUp_name.value,
        "amount": e_in_dbgApi_entUp_amt.value,
        "description": e_in_dbgApi_entUp_desc.value,
        "date": e_in_dbgApi_entUp_date.value,
        "completed": e_cbx_dbgApi_entUp_comp.checked ? 1 : 0
    });
});

/*> ELEMENT COLLECTION: Entry Complete <*/
const e_btn_dbgApi_ent_comp = document.getElementById("id_btn_dbgApi_ent_comp");
const e_in_dbgApi_entComp_entId = document.getElementById("id_in_dbgApi_entComp_entId");

e_btn_dbgApi_ent_comp.addEventListener("click", () => {
    entriesComplete(e_in_dbgApi_entComp_entId.value);
});

/*> ELEMENT COLLECTION: Entry Delete <*/
const e_btn_dbgApi_ent_del = document.getElementById("id_btn_dbgApi_ent_del");
const e_in_dbgApi_entDel_entId = document.getElementById("id_in_dbgApi_entDel_entId");

e_btn_dbgApi_ent_del.addEventListener("click", () => {
    entriesDelete(e_in_dbgApi_entDel_entId.value);
});

/*========================================*/
//> ENDPOINT COLLECTION: Planned entries
/*========================================*/

//> #? Hogy lehet megadni egy tervezett bejegyzésnek az érvényességi idejét? Hogy melyik hónaptól melyikig kell vele számolni?

/*> ELEMENT COLLECTION: Planned entries Get all <*/
const e_btn_dbgApi_plEnt_all = document.getElementById("id_btn_dbgApi_plEnt_all");

e_btn_dbgApi_plEnt_all.addEventListener("click", () => {
    plannedEntriesAll();
});

/*> ELEMENT COLLECTION: Planned entry Add <*/
const e_btn_dbgApi_plEnt_add = document.getElementById("id_btn_dbgApi_plEnt_add");
const e_in_dbgApi_plEntAdd_catId = document.getElementById("id_in_dbgApi_plEntAdd_catId");
const e_in_dbgApi_plEntAdd_name = document.getElementById("id_in_dbgApi_plEntAdd_name");
const e_in_dbgApi_plEntAdd_amt = document.getElementById("id_in_dbgApi_plEntAdd_amt");
const e_in_dbgApi_plEntAdd_dom = document.getElementById("id_in_dbgApi_plEntAdd_dom");

e_btn_dbgApi_plEnt_add.addEventListener("click", () => {
    plannedEntriesAdd({
        "categoryid": e_in_dbgApi_plEntAdd_catId.value,
        "name": e_in_dbgApi_plEntAdd_name.value,
        "amount": e_in_dbgApi_plEntAdd_amt.value,
        "dayofmonth": e_in_dbgApi_plEntAdd_dom.value
    });
});

/*> ELEMENT COLLECTION: Planned entry Status <*/
const e_btn_dbgApi_plEnt_stat = document.getElementById("id_btn_dbgApi_plEnt_stat");
const e_in_dbgApi_plEntStat_id = document.getElementById("id_in_dbgApi_plEntStat_id");

e_btn_dbgApi_plEnt_stat.addEventListener("click", () => {
    plannedEntriesStatus(e_in_dbgApi_plEntStat_id.value);
});

/******************************/
/******************************/
/******************************/

async function copyTokens() {
    await navigator.clipboard.writeText(`Access token:\n${e_in_dbgApi_authLogin_accessToken.value}\n\nRefresh token:\n${e_in_dbgApi_authLogin_refreshToken.value}`);
}

</script>
