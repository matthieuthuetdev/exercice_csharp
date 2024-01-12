<?php
$file = file("score.txt");

$joueurs = array();

foreach ($file as $ligne) {
    $elements = explode(":", $ligne);
    $joueurs[trim($elements[0])] = intval(trim($elements[1]));
}
asort($joueurs);
?>

<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="./style.css">
</head>

<body>
    <h1>bienvenue sur le tableau des scores du short blind test !</h1>
    <table>
        <tr>
            <th>indice</th>
            <th>valeur</th>
        </tr>
        <?php
        foreach ($joueurs as $indice => $valeur) :
        ?>
            <tr> 
                 </tr>
        <?php endforeach; ?>
    </table>
    <h1><a href="regle.html">voir les règles du jeu</a></h1>
    <p class="version">Version : 1.1</p>
    <p>un recontage des points va être effectuer pour tout les participant le 12/01/2023 dans l'après midi.<br>les points serons afficher pour chaque joueurs quand leurs déconte des point sera terminé.</p>
</body>

</html>
