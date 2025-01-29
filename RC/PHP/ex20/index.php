<?php
    include_once("header.php");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trabalho do chicao</title>
</head>
<body>
    <?php 
        include "info_inc.php"; 

        echo "<p>Nome: $nome<br>Localidade: $localidade<br>Ano: $ano<br>Escola: $escola</p>";
    ?>
</body>


<?php
    include_once("footer.php");
?>
