<?php

/******************************/
/******************************/
/******************************/

function recurGetDir($path = ".") {

$scanRes = scandir($path);

$ret = [
"dirs" => [],
"files" => []
];

for ($i=0; $i<count($scanRes); $i++) {

if (($scanRes[$i]==".") || ($scanRes[$i]=="..")) {
array_splice($scanRes, $i, 1);
$i--;
} // &if

else {
$scanRes[$i] = $path."/".$scanRes[$i];

if (isDir($scanRes[$i])) {
array_push($ret["dirs"], $scanRes[$i]);

$ret2 = recurGetDir($scanRes[$i]);

$ret["dirs"] = array_merge($ret["dirs"], $ret2["dirs"]);
$ret["files"] = array_merge($ret["files"], $ret2["files"]);

} // &if
else
array_push($ret["files"], $scanRes[$i]);

} // &else

} // &for $i

return($ret);

} // &func recurGetDir

/******************************/
/******************************/
/******************************/

function isDir($path) {
return ((fileperms($path) & 0x4000) == 0x4000);
} // &func isDir

/******************************/
/******************************/
/******************************/

function loadJavaScriptFiles() {
    $res = recurGetDir("js");

    //echo preg_replace("/\r\n|\n|\r/", BR, var_export($res, true));
    //return;

    foreach ($res["files"] as $file) {
        includeScript($file); //> This is wrong.
        //includeScript(substr($file, strlen(Pg::$projectRootPath)+1));
    } // &foreach
}

/******************************/
/******************************/
/******************************/

function includeScript($filePath) {
    if (substr($filePath, -3) == ".js")
        echo "<script type='text/javascript' src='".$filePath.g::$URLv."' defer></script>";
} // &func includeScript

?>