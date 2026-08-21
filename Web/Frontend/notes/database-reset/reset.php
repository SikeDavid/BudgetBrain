<?php

/*
- ca@260818-2-1700

http://localhost/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/notes/database-reset/reset.php

Consultation:
> https://chatgpt.com/c/6a84728c-c830-83ed-ae9e-37b8dd3c2efe : war

*/

$mysql = 'mysql';
$host = 'localhost';
$user = 'root';
$password = '';
$database = 'budgetbrain_db';

$sqlFile = __DIR__ . 'reset.sql';

$command =
    escapeshellarg($mysql) .
    ' --host=' . escapeshellarg($host) .
    ' --user=' . escapeshellarg($user) .
    ' --password=' . escapeshellarg($password) .
    ' ' . escapeshellarg($database) /*.
    ' < ' . escapeshellarg($sqlFile) .
    ' 2>&1'*/;

$output = [];
$returnCode = 0;

exec($command, $output, $returnCode);

header('Content-Type: application/json');







$output = [];
$returnCode = 0;

$lastLine = exec($command, $output, $returnCode);

echo '<pre>';
echo "COMMAND:\n";
echo htmlspecialchars($command);

echo "\n\nRETURN CODE:\n";
echo $returnCode;

echo "\n\nLAST LINE:\n";
echo htmlspecialchars($lastLine);

echo "\n\nOUTPUT:\n";
echo htmlspecialchars(implode("\n", $output));

echo '</pre>';




if ($returnCode === 0) {
    echo json_encode([
        'success' => true,
        'message' => 'Database reset successfully.'
    ]);
} else {
    http_response_code(500);

    echo json_encode([
        'success' => false,
        'message' => 'Database reset failed.',
        'output' => $output
    ]);
}