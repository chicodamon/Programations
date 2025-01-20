<?php
do {
    $randomNumber = rand(1, 10);
    echo "Número sorteado: $randomNumber<br>";
} while ($randomNumber != 5);
echo "Ciclo interrompido porque o número 5 foi sorteado.";
?>
