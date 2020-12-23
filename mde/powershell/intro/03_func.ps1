
function Soustraire([Int] $nb1, [Int] $nb2) {
	$nb1 - $nb2
}

$saisie1 = Read-Host "Saisissez un 1er nombre"
$saisie2 = Read-Host "Saisissez un 2nd nombre"

Soustraire($saisie2, $saisie1)
Soustraire($saisie1, $saisie2)

