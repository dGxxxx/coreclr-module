param(
    $path,
    $os,
    $pack = $true
)

Write-Host "Downloading latest dotnet"
Write-Host $path
Write-Host $os
Write-Host $pack

$start = $pwd

Set-Location $path

$dotnetRelease = Invoke-WebRequest 'https://dotnetcli.blob.core.windows.net/dotnet/release-metadata/8.0/releases.json' | ConvertFrom-Json

$dotnetVersion = $dotnetRelease."latest-release" 

if ($os -eq "win") {
    $file = "dotnet-sdk-win-x64.zip"
}
else {
    $file = "dotnet-sdk-linux-x64.tar.gz"
}

$dotnetSdkZipUrl = $dotnetRelease.releases[0].sdk.files | Where-Object { $_.name -eq $file } | Select-Object -ExpandProperty "url" | Out-String

Write-Host "Download dotnet version: $dotnetVersion"
Write-Host "Download from cdn: $dotnetSdkZipUrl"

if ($os -eq "win") {
    $dfile = "dotnet_version_$dotnetVersion.zip"
}
else {
    $dfile = "dotnet_version_$dotnetVersion.tar.gz"
}

Invoke-RestMethod -Uri $dotnetSdkZipUrl -OutFile "$dfile"

Write-Host "Download successfully to $dfile" 

if ($os -eq "win") {
    Expand-Archive -LiteralPath "$dfile" -DestinationPath "dotnet_version_$dotnetVersion_$os"
}
else {
    mkdir "dotnet_version_$dotnetVersion_$os"
    tar -zxvf "$dfile" -C "dotnet_version_$dotnetVersion_$os"
}

Write-Host "Extraxt successfully"

if ($os -eq "win") {
    Set-Location "dotnet_version_$dotnetVersion_$os\packs\Microsoft.NETCore.App.Host.win-x64\$dotnetVersion\runtimes\win-x64\native"
}
else {
    Set-Location "dotnet_version_$dotnetVersion_$os\packs\Microsoft.NETCore.App.Host.linux-x64\$dotnetVersion\runtimes\linux-x64\native"
}

if ($pack) {
    Write-Host "Pack libnethost"

    if ($os -eq "win") {
        tar -cvzf $path\libnethost.tar *
    }
    else {
        tar -cvzf "$path/libnethost.tar" *
    }

    Write-Host "Pack successfully"
    Set-Location $start
}