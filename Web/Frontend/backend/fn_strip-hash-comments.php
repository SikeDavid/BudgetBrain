<?php

function stripHashComments($str) {

    $lines = preg_split("/\r\n|\n|\r/", $str);

    foreach ($lines as $key => $line) {
        if ($line !== "" && $line[0] === "#")
            unset($lines[$key]);
    }

    return implode("\n", $lines);
}

?>