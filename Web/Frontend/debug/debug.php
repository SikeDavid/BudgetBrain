<?php
    $testUser = [
        "name" => "BitMiller",
        "email" => "bitmiller@test.com",
        "password" => "Almafa123-"
    ];
?>
<script>
    const testUser = <?= json_encode($testUser); ?>;
    //console.log(testUser);
</script>

<div>
    <hr>

    <button onclick="registration()">Registration</button>
    <br>
    <input id="id_reg_userName" value="TestUser01">
    <br>
    <input id="id_reg_email" value="testuser01@email.com">
    <br>
    <input id="id_reg_password" value="Password01!">

    <hr>

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

    <hr>

    <button onclick="refreshToken()">Refresh token</button>
    <br>
    <input id="id_accessToken" placeholder="Access token" readonly>

    <hr>

    <button onclick="logout()">Logout</button>

    <hr>
    <hr>

    <button onclick="categoriesAll()">Categories - All</button>

    <hr>

    <button onclick="categoriesAdd()">Categories - Add</button>
    <br>
    <input id="id_in_cat_addName" placeholder="Category name">
    <br>
    <label for="id_sel_cat_item">Item type:</label>
    <br>
    <select id="id_sel_cat_item" name="id_sel_cat_item">
        <option value="income">Income</option>
        <option value="expense">Expense</option>
    </select>
    <br>
    <label for="id_cbx_cat_inUse">In use:</label>
    <input type="checkbox" id="id_cbx_cat_inUse" name="id_cbx_cat_inUse" checked>

    <hr>

    <button onclick="categoriesUpdate(e_in_catUp_id.value)">Categories - Update</button>
    <br>
    <input id="id_in_catUp_id" type="number" placeholder="Category ID" value="7">
    <br>
    <input id="id_in_catUp_addName" placeholder="Category name">
    <br>
    <label for="id_sel_catUp_item">Item type:</label>
    <br>
    <select id="id_sel_catUp_item" name="id_sel_catUp_item">
        <option value="income">Income</option>
        <option value="expense">Expense</option>
    </select>
    <br>
    <label for="id_cbx_catUp_inUse">In use:</label>
    <input type="checkbox" id="id_cbx_catUp_inUse" name="id_cbx_catUp_inUse" checked>

    <hr>

    <button onclick="categoriesStatus(e_in_catStat_id.value)">Categories - Status</button>
    <br>
    <input id="id_in_catStat_id" type="number" placeholder="Category ID" value="7">

    <hr>
    <hr>

    <button onclick="entriesGet(e_in_entGet_id.value)">Entries - Get</button>
    <br>
    <input id="id_in_entGet_id" type="number" placeholder="ID" value="11">

    <hr>

    <button onclick="entriesGetForMonth(e_in_entGetY.value, e_in_entGetM.value)">Entries - Get for month</button>
    <br>
    <input id="id_in_entGetY" type="number" placeholder="Year" value="2026">
    <br>
    <input id="id_in_entGetM" type="number" placeholder="Month" value="4">

    <hr>

    <button onclick="entriesAdd()">Entries - Add</button>
    <br>
    <input id="id_in_entAdd_catId" type="number" placeholder="Category ID" value="7">
    <br>
    <input id="id_in_entAdd_amt" type="number" placeholder="Amount" value="1000">
    <br>
    <input id="id_in_entAdd_desc" placeholder="Description" value="Some basic text.">
    <br>
    <input id="id_in_entAdd_date" placeholder="Date" value="2026-04-01">

    <hr>

    <button onclick="entriesUpdate(e_in_entUp_entId.value)">Entries - Update</button>
    <br>
    <input id="id_in_entUp_entId" type="number" placeholder="Entry ID" value="11">
    <br>
    <input id="id_in_entUp_catId" type="number" placeholder="Category ID" value="7"><!-- 8 -->
    <br>
    <input id="id_in_entUp_name" placeholder="Category name" value="Fizetés"><!-- Rezsi -->
    <br>
    <input id="id_in_entUp_amt" type="number" placeholder="Amount" value="2000">
    <br>
    <input id="id_in_entUp_desc" placeholder="Description" value="Some basic text as well.">
    <br>
    <input id="id_in_entUp_date" placeholder="Date" value="2026-04-02">
    <br>
    <label for="id_cbx_entUp_comp">Completed:</label>
    <input type="checkbox" id="id_cbx_entUp_comp" name="id_cbx_entUp_comp" checked>

    <hr>

    <button onclick="entriesComplete(e_in_entComp_entId.value)">Entries - Complete</button>
    <br>
    <input id="id_in_entComp_entId" type="number" placeholder="Entry ID" value="11">

    <hr>

    <button onclick="entriesDelete(e_in_entDel_entId.value)">Entries - Delete</button>
    <br>
    <input id="id_in_entDel_entId" type="number" placeholder="Entry ID" value="11">

    <hr>
    <hr>

    <button onclick="plannedEntriesAll()">Planned Entries - Get All</button>

    <hr>

    <button onclick="plannedEntriesAdd()">Planned Entries - Add</button>
    <br>
    <input id="id_in_PlEntAdd_catId" type="number" placeholder="Category ID" value="7">
    <br>
    <input id="id_in_PlEntAdd_name" placeholder="Name" value="Fizetés">
    <br>
    <input id="id_in_PlEntAdd_amt" type="number" placeholder="Amount" value="7000">
    <br>
    <input id="id_in_PlEntAdd_dom" type="number" placeholder="Day of month" value="12">

    <hr>

    <button onclick="plannedEntriesStatus(e_in_PlEntStat_PlEntId.value)">Planned Entries - Status</button>
    <br>
    <input id="id_in_PlEntStat_PlEntId" type="number" placeholder="Planned entry ID" value="7">

    <hr>
</div>



<script>

/*

const e_ = document.getElementById("id_");
*/

const e_reg_userName = document.getElementById("id_reg_userName");
const e_reg_email = document.getElementById("id_reg_email");
const e_reg_password = document.getElementById("id_reg_password");

const e_login_userName = document.getElementById("id_login_userName");
const e_login_password = document.getElementById("id_login_password");
const e_login_accessToken = document.getElementById("id_login_accessToken");
const e_login_refreshToken = document.getElementById("id_login_refreshToken");

const e_accessToken = document.getElementById("id_accessToken");

const e_in_cat_addName = document.getElementById("id_in_cat_addName");
const e_sel_cat_item = document.getElementById("id_sel_cat_item");
const e_cbx_cat_inUse = document.getElementById("id_cbx_cat_inUse");

const e_in_catUp_id = document.getElementById("id_in_catUp_id");
const e_in_catUp_addName = document.getElementById("id_in_catUp_addName");
const e_sel_catUp_item = document.getElementById("id_sel_catUp_item");
const e_cbx_catUp_inUse = document.getElementById("id_cbx_catUp_inUse");

const e_in_catStat_id = document.getElementById("id_in_catStat_id");

const e_in_entGet_id = document.getElementById("id_in_entGet_id");

const e_in_entGetY = document.getElementById("id_in_entGetY");
const e_in_entGetM = document.getElementById("id_in_entGetM");

const e_in_entAdd_catId = document.getElementById("id_in_entAdd_catId");
const e_in_entAdd_amt = document.getElementById("id_in_entAdd_amt");
const e_in_entAdd_desc = document.getElementById("id_in_entAdd_desc");
const e_in_entAdd_date = document.getElementById("id_in_entAdd_date");

const e_in_entUp_entId = document.getElementById("id_in_entUp_entId");
const e_in_entUp_catId = document.getElementById("id_in_entUp_catId");
const e_in_entUp_name = document.getElementById("id_in_entUp_name");
const e_in_entUp_amt = document.getElementById("id_in_entUp_amt");
const e_in_entUp_desc = document.getElementById("id_in_entUp_desc");
const e_in_entUp_date = document.getElementById("id_in_entUp_date");
const e_cbx_entUp_comp = document.getElementById("id_cbx_entUp_comp");

const e_in_entComp_entId = document.getElementById("id_in_entComp_entId");

const e_in_entDel_entId = document.getElementById("id_in_entDel_entId");

/* Hogy lehet megadni egy tervezett bejegyzésnek az érvényességi idejét? Hogy melyik hónaptól melyikig kell vele számolni? */
const e_in_PlEntAdd_catId = document.getElementById("id_in_PlEntAdd_catId");
const e_in_PlEntAdd_name = document.getElementById("id_in_PlEntAdd_name");
const e_in_PlEntAdd_amt = document.getElementById("id_in_PlEntAdd_amt");
const e_in_PlEntAdd_dom = document.getElementById("id_in_PlEntAdd_dom");

const e_in_PlEntStat_PlEntId = document.getElementById("id_in_PlEntStat_PlEntId");

</script>
