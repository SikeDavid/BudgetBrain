<?php
/*
#Created @260830-7-1745
#Source
> http://127.0.0.1/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/notes/database-generation/stage_04/stage_04_02_entries.php

*/

const BR = "<br>";
const NS = "&nbsp;";
const HTML_TAB = NS.NS.NS.NS;
const LF = "\n";
const CR = "\r";
const TAB = "\t";
const BITMILLER_USER_ID = 7;
const FIT_MAX = 10;

class g {
    public static $t = "";
    public static $outDir = "";
    public static $balance = 0;
    public static $catsFromFiles = [
        "incomes" => [],
        "expenses" => []
    ];
    public static $incomeFixData = [];
    public static $expenseFixData = [];
    public static $incomeCasualData = [];
    public static $expenseCasualData = [];
    public static $users;
    public static $categories;
    public static $entries = [];
    public static $bitmillerUserId;

    public static function init(): void {
        self::$t = time();
        self::$outDir = "output/".self::$t;
        self::$users = getUsersFromDatabase();
        self::$categories = getCategoriesFromDatabase();
        self::$bitmillerUserId = self::$users["BitMiller"];
        //echo self::$bitmillerUserId.BR.BR;
    }
}
g::init();

//echo "\$bitmillerUserId:".g::$bitmillerUserId.BR.BR;

class db {
    public static $host = "localhost";
    public static $db = "budgetbrain_db";
    public static $user = "root";
    public static $pass = "";
    public static $port = 3307;
}
/*
class Category {
    public $category_id;
    public $name;
    public $type;

    public function __construct($category_id, $name) {

    }
}
*/
//> user_id, category_id, amount, description, date, completed
class Entry {
    public $user_id;
    public $category_id;
    public $amount;
    public $description;
    public $date;
    public $completed;

    public function __construct(
                        $category_id,
                        $amount,
                        $description,
                        $date,
                        $user_id = BITMILLER_USER_ID,
                        $completed = 1) {
        $this->user_id = $user_id;
        /*if ($user_id === null)
            $user_id = g::$bitmillerUserId;*/
        $this->category_id = $category_id;
        $this->amount = $amount;
        $this->description = $description;
        $this->date = $date;
        $this->completed = $completed;
    }
}

//echo g::$t;

$inputPath = "input/incomes";
$incomeFiles = scandir($inputPath);

foreach ($incomeFiles as $k => $v) {
    if ($v == "." || $v == ".." || mb_substr($v, -4) != ".csv")
        unset($incomeFiles[$k]);
}
$incomeFiles = array_values($incomeFiles);

foreach ($incomeFiles as $f) {
    //echo BR.$inputPath."/".$f;
    $categoryName = mb_substr($f, 0, -4);
    g::$catsFromFiles["incomes"][] = $categoryName;
    $entryData = readCSV($inputPath."/".$f, $categoryName, 0.6);
    g::$incomeFixData = array_merge(g::$incomeFixData, $entryData["fixes"]);
    g::$incomeCasualData = array_merge(g::$incomeCasualData, $entryData["casuals"]);
}

$fixIncomes = testMonthlyFixEntries(g::$incomeFixData);



echo BR.BR;




$inputPath = "input/expenses";
$expenseFiles = scandir($inputPath);

foreach ($expenseFiles as $k => $v) {
    if ($v == "." || $v == ".." || mb_substr($v, -4) != ".csv")
        unset($expenseFiles[$k]);
}
$expenseFiles = array_values($expenseFiles);

foreach ($expenseFiles as $f) {
    //echo BR.$inputPath."/".$f;
    $categoryName = mb_substr($f, 0, -4);
    g::$catsFromFiles["expenses"][] = $categoryName;
    $entryData = readCSV($inputPath."/".$f, $categoryName, 0.45);
    g::$expenseFixData = array_merge(g::$expenseFixData, $entryData["fixes"]);
    g::$expenseCasualData = array_merge(g::$expenseCasualData, $entryData["casuals"]);
}

$fixExpenses = testMonthlyFixEntries(g::$expenseFixData);




mkdir(g::$outDir);

echo BR."Fix incomes: $fixIncomes".BR."Fix expenses: $fixExpenses".BR.BR;

generateCategoryData();
generateData("2024-02", "2024-04");







/******************************/
/******************************/
/******************************/

function readCSV($filePath, $categoryName, $scaler) {
    //echo $categoryName.BR;return;
    $data = file_get_contents($filePath);

    $data = preg_split("/\r\n|\n|\r/", $data);

    foreach ($data as $k => $v)
        if ($v == "")
            unset($data[$k]);
    $data = array_values($data);

    $array = [];

    foreach ($data as $d) {
        $s = explode(",", $d);
        if (count($s) != 4) {
            echo "<div style='color:red;'>Error: CSV has an element count error in line: ".$d."<div>";
            continue;
        }
        foreach ($s as &$se) {
            $se = trim($se);
        }
        unset($se);
        //$s = array_values($s);
        //var_dump($s); echo BR; continue;

        $from = $s[2];
        $to = $s[3];
        $avg = ($from+$to)/2;

        $fix = $s[2] == $s[3];

        $array[] = [
            "name" => $s[0],
            "monthly" => $s[1],
            "from" => $fix ? intval($s[2]*$scaler) : intval(round($avg*0.85*$scaler)),
            "to" => $fix ? intval($s[2]*$scaler) : intval(round($avg*1.15*$scaler)),
            "category" => $categoryName
        ];
    }

    $fixes = [];
    $casuals = [];

    foreach ($array as $arr) {
        if ($arr["monthly"] == 1)
            $fixes[] = $arr;
        else
            $casuals[] = $arr;
    }

    return [
        "fixes" => $fixes,
        "casuals" => $casuals
    ];
} // &func readCSV

/******************************/
/******************************/
/******************************/

function testMonthlyFixEntries($data) {

    $amount = 0;

    foreach ($data as $d) {
        //echo var_export($d, true).BR.BR;
        if ($d["monthly"] == 1) {
            $amount += rand($d["from"], $d["to"]);
            //echo var_export($d, true).BR;
        }
    }

    //echo BR."Monthly fix entries are: $amount".BR.BR;
    return $amount;
}

/******************************/
/******************************/
/******************************/

function generateFixEntries($yearMonth, $data) {
    $days = getDaysArrayInYearMonth($yearMonth);

    foreach ($data as $d) {
        /*var_dump($d);
        echo BR;*/
        $randomDate = $days[rand(0, count($days)-1)]->format("Y-m-d");
        echo "Random date: ".$randomDate.BR;
        g::$entries[] = new Entry(
                        category_id: g::$categories[$d["category"]],
                        amount: rand($d["from"], $d["to"]),
                        description: $d["name"],
                        date: $randomDate
                        );
    }
    echo BR;
}

/******************************/
/******************************/
/******************************/

function generateCasualEntries($yearMonth, $data, $aimFrom, $aimTo) {
    $days = getDaysArrayInYearMonth($yearMonth);
    //echo $days[0]->format("Y-m-d").BR;

    $balance = 0;
    $fitCounter = 0;

    while ($balance < $aimFrom && $fitCounter < FIT_MAX) {
        $randomDate = $days[rand(0, count($days)-1)]->format("Y-m-d");
        echo "Random date: ".$randomDate.BR;

        $idx = rand(0, count($data)-1);
        $randomAmount = rand($data[$idx]["from"], $data[$idx]["to"]);

        if ($balance+$randomAmount <= $aimTo) {
            g::$entries[] = new Entry(
                            category_id: g::$categories[$data[$idx]["category"]],
                            amount: $randomAmount,
                            description: $data[$idx]["name"],
                            date: $randomDate
                            );
            $balance += $randomAmount;
        }
        else
            $fitCounter++;
    }

    echo "Balance: $balance".BR.BR;
}

/******************************/
/******************************/
/******************************/

function generateData($yearMonthStart, $yearMonthEnd) {
    $dateStart = new DateTime($yearMonthStart."-01");
    $dateEnd = new DateTime($yearMonthEnd."-01");
    $dateEnd->modify("+1 month");

    $months = new DatePeriod(
        $dateStart,
        new DateInterval("P1M"),
        $dateEnd
    );


    foreach ($months as $month) {
        generateFixEntries($month->format("Y-m"), g::$incomeFixData);
        generateFixEntries($month->format("Y-m"), g::$expenseFixData);
        generateCasualEntries($month->format("Y-m"), g::$incomeCasualData, 500000, 520000);
        generateCasualEntries($month->format("Y-m"), g::$expenseCasualData, 500000, 520000);
    }

    entriesSortByDate();
    exportEntriesInDateRange($dateStart->format("Y-m-d"), (clone $dateEnd)->modify("-1 day")->format("Y-m-d"));

    echo preg_replace("/\r\n|\n|\r/", BR, var_export(g::$entries, true));
    echo BR.BR;
}

/******************************/
/******************************/
/******************************/

function getDaysArrayInYearMonth($yearMonth) {
    //echo "getDaysArrayInYearMonth()".BR.BR;
    $yearMonth = new DateTime($yearMonth."-01");
    $yearMonthStart = new DateTime($yearMonth->format("Y-m-01"));
    $yearMonthEnd = (clone $yearMonthStart)->modify("+1 month");

    $days = new DatePeriod(
        $yearMonthStart,
        new DateInterval("P1D"),
        $yearMonthEnd
    );
/*
    echo "Month: ".$yearMonth->format("Y-m").BR;

    foreach ($days as $day) {
        echo HTML_TAB.$day->format("Y-m-d").BR;
    }
*/
    return iterator_to_array($days);
}

/******************************/
/******************************/
/******************************/

function getUsersFromDatabase() {
    $pdo = new PDO(
        "mysql:host=".db::$host.";port=".db::$port.";dbname=".db::$db.";charset=utf8mb4",
        db::$user,
        db::$pass,
        [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]
    );

    $stmt = $pdo->query("SELECT user_id, username FROM users");

    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
    /*print_r($result);
    echo BR.BR;*/

    $usrs = [];
    foreach ($result as $r) {
        $usrs[$r["username"]] = $r["user_id"];
    }

    return $usrs;
}

/******************************/
/******************************/
/******************************/

function getCategoriesFromDatabase() {
    $pdo = new PDO(
        "mysql:host=".db::$host.";port=".db::$port.";dbname=".db::$db.";charset=utf8mb4",
        db::$user,
        db::$pass,
        [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]
    );

    $stmt = $pdo->query("SELECT * FROM categories");

    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
    /*print_r($result);
    echo BR.BR;*/

    $cats = [];

    foreach ($result as $r) {
        if (intval($r["user_id"]) == BITMILLER_USER_ID)
            $cats[$r["name"]] = $r["category_id"];
    }

    /*print_r($cats);
    echo BR.BR;*/

    return $cats;
}

/******************************/
/******************************/
/******************************/

function entriesSortByDate() {
    for ($i = 0; $i < count(g::$entries)-1; $i++)
    for ($j = $i+1; $j < count(g::$entries); $j++) {
        if (g::$entries[$i]->date > g::$entries[$j]->date)  {
            $tmp = g::$entries[$i];
            g::$entries[$i] = g::$entries[$j];
            g::$entries[$j] = $tmp;
        }
    }
}

/******************************/
/******************************/
/******************************/

function exportEntriesInDateRange($dateStart, $dateEnd) {

    $strArr = [];
//> (2, 1, 300000, 'Fizetés', '2026-04-01', true),
    foreach (g::$entries as $e) {
        if ($e->date >= $dateStart && $e->date <= $dateEnd)
            $strArr[] = "(".BITMILLER_USER_ID.", ".$e->category_id.", ".$e->amount.", '".$e->description."', '".$e->date."', 1)";
    }

    $strEnt = "--> Entries from '$dateStart' to '$dateEnd'".LF;
    $strEnt .= "INSERT INTO entries (user_id, category_id, amount, description, date, completed) VALUES".LF;

    for ($i = 0; $i < count($strArr); $i++) {
        $strEnt .= $strArr[$i];
        if ($i+1 == count($strArr))
            $strEnt .= ";".LF;
        else
            $strEnt .= ",".LF;
    }

    file_put_contents(g::$outDir."/03_add-entries.sql", $strEnt);
}

/******************************/
/******************************/
/******************************/

function generateCategoryData() {
    $strCat = "INSERT INTO categories (user_id, name, type) VALUES".LF;

    for ($i = 0; $i < count(g::$catsFromFiles["incomes"]); $i++) {
        $strCat .= "(".BITMILLER_USER_ID.", '".g::$catsFromFiles["incomes"][$i]."', 'income')";
        if ($i+1 == count(g::$catsFromFiles["incomes"]))
            $strCat .= ";".LF;
        else
            $strCat .= ",".LF;
    }

    $strCat .= LF."INSERT INTO categories (user_id, name, type) VALUES".LF;

    for ($i = 0; $i < count(g::$catsFromFiles["expenses"]); $i++) {
        $strCat .= "(".BITMILLER_USER_ID.", '".g::$catsFromFiles["expenses"][$i]."', 'expense')";
        if ($i+1 == count(g::$catsFromFiles["expenses"]))
            $strCat .= ";".LF;
        else
            $strCat .= ",".LF;
    }

    file_put_contents(g::$outDir."/02_add-categories.sql", $strCat);
}

?>