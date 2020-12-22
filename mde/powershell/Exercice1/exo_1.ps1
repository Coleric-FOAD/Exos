$processName = $args[0]

Write-Host "Affichage des processus contenant : $processName"

$p = Get-Process | Where-Object { $_.Name -like "*$processName*" }

$s = Get-Service | Where-Object { $_.ServiceName -like "*goo*" }


$p | Format-List Id, Name, Description, Product, VM, StartTime

