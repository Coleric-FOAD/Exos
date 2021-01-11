Class Calcul 
{
	[int] $nb1
	[int] $nb2

	Calcul()
	{
		Write-Host "Constructeur de calcul"
	}

	DemanderNombres()
	{
		$this.nb1 = Read-Host "Saisissez un 1er nombre"
		$this.nb2 = Read-Host "Saisissez un 2nd nombre"
		$this.Additionner()
		$this.Soustraire()
	}

	Additionner()
	{
		$result = $this.nb1 + $this.nb2
		Write-Host "Le résultat de l'addition est: $result"
	}

	Soustraire()
	{
		$result = $this.nb1 - $this.nb2
		Write-Host "Le résultat de la soustraction est: $result"
	}
}

function New-CalculClass { return [Calcul]::new() }
