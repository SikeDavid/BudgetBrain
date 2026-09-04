
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
