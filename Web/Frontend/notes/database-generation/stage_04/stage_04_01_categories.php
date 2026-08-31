<?php
/*
#Created @260830-7-1745
#Source
> http://127.0.0.1/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/notes/database-generation/stage_04/stage_04_01_categories.php

*/

class g {
    public static $t = "";
    public static $outDir = "";
    public static $balance = 0;
    public static $incomeFixData = [];
    public static $incomeCasualData = [];
    public static $expenseFixData = [];
    public static $expenseCasualData = [];

    public static function init(): void {
        self::$t = time();
        self::$outDir = "output/".self::$t;
    }
}
g::init();

const BR = "<br>";
const NS = "&nbsp;";
const HTML_TAB = NS.NS.NS.NS;
const LF = "\n";
const CR = "\r";
const TAB = "\t";
const BITMILLER_USER_ID = 7;

//echo g::$t;

$categories = [
    "incomes" => [],
    "expenses" => []
];



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
    $categories["incomes"][] = $categoryName;
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
    $categories["expenses"][] = $categoryName;
    $entryData = readCSV($inputPath."/".$f, $categoryName, 0.45);
    g::$expenseFixData = array_merge(g::$expenseFixData, $entryData["fixes"]);
    g::$expenseCasualData = array_merge(g::$expenseCasualData, $entryData["casuals"]);
}

$fixExpenses = testMonthlyFixEntries(g::$expenseFixData);

//echo str_replace("\t", TAB, preg_replace("/\r\n|\n|\r/", BR, var_export($expenseData, true)));
//echo str_replace("\t", TAB, preg_replace("/\r\n|\n|\r/", BR, var_export($categories, true)));

mkdir(g::$outDir);



$strCat = "INSERT INTO categories (user_id, name, type) VALUES".LF;

for ($i = 0; $i < count($categories["incomes"]); $i++) {
    $strCat .= "(".BITMILLER_USER_ID.", '".$categories["incomes"][$i]."', 'income')";
    if ($i+1 == count($categories["incomes"]))
        $strCat .= ";".LF;
    else
        $strCat .= ",".LF;
}


$strCat .= LF."INSERT INTO categories (user_id, name, type) VALUES".LF;

for ($i = 0; $i < count($categories["expenses"]); $i++) {
    $strCat .= "(".BITMILLER_USER_ID.", '".$categories["expenses"][$i]."', 'expense')";
    if ($i+1 == count($categories["expenses"]))
        $strCat .= ";".LF;
    else
        $strCat .= ",".LF;
}



file_put_contents(g::$outDir."/02_add-categories.sql", $strCat);



echo BR."Fix incomes: $fixIncomes".BR."Fix expenses: $fixExpenses".BR.BR;

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

function generateFixIncomes($incomes, $yearMonth) {
    $days = getDaysArrayInYearMonth($yearMonth);

    $data = [];

    return $data;
}

/******************************/
/******************************/
/******************************/

function generateFixExpenses($expenses, $yearMonth) {
    $data = [];

    return $data;
}

/******************************/
/******************************/
/******************************/

function generateCasualIncomes($incomes, $yearMonth, $aimFrom, $aimTo) {

}

/******************************/
/******************************/
/******************************/

function generateCasualExpenses($expenses, $yearMonth, $aimFrom, $aimTo) {
    $days = getDaysArrayInYearMonth($yearMonth);
    echo $days[0]->format("Y-m-d").BR;

    $balance = 0;

    while ($balance < $aimFrom) {
        $idx = rand(0, count($days)-1);
    }
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
        generateCasualExpenses(null, $month->format("Y-m"), null, null);
    }
}

/******************************/
/******************************/
/******************************/

function getDaysArrayInYearMonth($yearMonth) {
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

?>