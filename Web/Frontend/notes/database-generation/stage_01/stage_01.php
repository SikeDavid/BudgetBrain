<?php

/*
- #Created: @260828-5-1715

Leni:
http://127.0.0.1/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/notes/database-generation/stage_01/stage_01.php

*/

const BR = "<br>";

//const FILE_NAME = "categories.txt";
//const FILE_NAME = "expenses.txt";
const FILE_NAME = "incomes.txt";

$data = file_get_contents(FILE_NAME);

$data = preg_split("/\r\n|\n|\r/", $data);



/*
$linebreakCounter = 0;

foreach ($data as &$d) {
    if ($d != "") {
        if ($d[strlen($d)-1] == " ")
            $d = substr($d, 0, strlen($d)-1);
        if ($d[strlen($d)-1] == ",")
            $d = substr($d, 0, strlen($d)-1);

        echo $d.BR;
    }
    else {
        $linebreakCounter++;
        echo "#LINEBREAK_".$linebreakCounter.BR;
    }
}

unset($d);

exit;
*/




//$data = array_values($data);
$data2 = [];

foreach ($data as $d) {
    $i = 0;
    while ($i < count($data2) && $d != $data2[$i])
        $i++;
    if ($i >= count($data2))
        $data2[] = $d;
    else
        echo "<div style='color:red;'>".$d."</div>";
}

foreach ($data2 as $d)
    echo $d.BR;

//echo BR.BR;
//echo preg_replace("/\r\n|\n|\r/", BR, var_export($data2, true));

?>