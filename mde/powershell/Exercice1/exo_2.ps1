
$servName = Read-Host "Veuillez saisir le nom du service : "

$nombre = Get-Service | where { $_.name -like "*$servName*"} | Measure-Object

$services = Get-Service | where { $_.name -like "*$servName*"}

if ($nombre.Count -gt 0)
{
    Write-Host "Voici les services trouvés : "

    $count = 0;

    foreach($serv in $services)
    {
        Write-Host -foregroundcolor Red [$count] $serv.DisplayName - $serv.Name "  " Status : $serv.Status

        $count++
    }


    for($i = 0; $i -lt $nombre.Count; $i++) 
    {

        if($services[$i].CanStop)
        {
            Write-Host -foregroundcolor Green [$i] $services[$i].DisplayName - $services[$i].Name "  " Status : $services[$i].Status
        }
    }

}
else
{
    Write-Host Aucun service trouvé
}