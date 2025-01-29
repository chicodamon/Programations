<!DOCTYPE html>
<html lang="pt">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tabuada</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f4f4f4;
        }
        table {
            width: 50%;
            margin: 0 auto;
            border-collapse: collapse;
        }
        th, td {
            border: 1px solid #ccc;
            padding: 10px;
            text-align: center;
        }
        th {
            background-color: #333;
            color: white;
        }
        tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        tr:nth-child(odd) {
            background-color: #e9e9e9;
        }
    </style>
</head>
<body>
    <h1 style="text-align: center;">Tabuada de 1 a 10</h1>
    <table>
        <thead>
            <tr>
                <th>Número</th>
                <th>Multiplicador</th>
                <th>Resultado</th>
            </tr>
        </thead>
        <tbody>
            <?php
            for ($i = 1; $i <= 10; $i++) {
                for ($j = 1; $j <= 10; $j++) {
                    echo "<tr>
                            <td>$i</td>
                            <td>$j</td>
                            <td>" . ($i * $j) . "</td>
                          </tr>";
                }
            }
            ?>
        </tbody>
    </table>
</body>
</html>
