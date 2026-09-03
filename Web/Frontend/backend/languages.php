<?php

header("Content-Type: application/json; charset=utf-8");

$data = null;
$json = json_decode(file_get_contents("languages.json"), true);
$msg = "";

if (isset($_GET["lang"])) {
    if (array_key_exists($_GET["lang"], $json["languages"])) {
        $msg = "Language exists!";
        $data = [];
        foreach($json["data"] as $k => $v) {
            $data[$k] = $v[$_GET["lang"]];
        }
    }
}
else {
    $data = $json["languages"];
}

echo json_encode(["data" => $data, "message" => $msg], JSON_UNESCAPED_UNICODE);

//echo json_encode(true);

?>