Set-ExecutionPolicy Unrestricted

param
(
    [String]$LogDirectory="C:\Temp\ChefDemo.Install",
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

$scriptPath = Split-Path $MyInvocation.MyCommand.Path
echo "Additional Arguments: $AdditionalArgs"

# ensure log directory exists
if(!(Test-Path $LogDirectory))
{
    New-Item -Path $LogDirectory -ItemType D
}

&$msbuildExe $scriptPath\install.proj /target:"$Targets" /property:"$AdditionalArgs" /filelogger /fileloggerparameters:"LogFile=$LogDirectory\install.log"

echo "MSBuild returned exit code $LastExitCode"
exit $LastExitCode
