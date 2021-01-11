function Soustraire([int] $nb1, [int] $nb2) {
	$nb1 - $nb2
}

$saisie1 = Read-Host "Saisissez un 1er nombre"
$saisie2 = Read-Host "Saisissez un 2nd nombre"

$saisie1 = $saisie1 -as [int]
$saisie2 = $saisie2 -as [int]

# Write-Host $saisie1.GetType()

Soustraire $saisie2 $saisie1 
Soustraire $saisie1 $saisie2  

