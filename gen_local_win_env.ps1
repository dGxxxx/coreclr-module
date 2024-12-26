$start = $pwd

$nethostPath = "runtime/nethost"
$tmpPath = "runtime/tmp"

if (Test-Path -Path $nethostPath) {
    # Delete folder
    Remove-Item -Path $nethostPath -Recurse -Force
    Write-Host "Folder '$nethostPath' deleted"
} 

New-Item -ItemType Directory -Path $nethostPath | Out-Null
Write-Host "Folder '$nethostPath' created"

if (Test-Path -Path $tmpPath) {
    # Delete folder
    Remove-Item -Path $tmpPath -Recurse -Force
} 

New-Item -ItemType Directory -Path $tmpPath | Out-Null

& "./download_dotnet.ps1" $tmpPath "win" $false

$currentDir = Get-Location
Copy-Item -Path "$currentDir\*" -Destination "$start/$nethostPath" -Recurse -Force
Remove-Item -Path $tmpPath -Recurse -Force

Set-Location $start