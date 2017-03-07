param
(
    [String]$LogDirectory="C:\temp\Sample.Install",
    [String]$AdditionalArgs="",
    [String]$Targets=""
)
echo "Running the install..."

$msbuildExe = "$env:windir\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
if(!(Test-Path $msbuildExe))
{
    echo "MSBuild not found at $msbuildExe"
    exit 1
}

&$msbuildExe C:\temp\Sample.Install\tools\install.proj /target:"Dynamic" /filelogger /fileloggerparameters:"LogFile=$LogDirectory\install.log"