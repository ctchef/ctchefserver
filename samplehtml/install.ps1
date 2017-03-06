echo "Running the install..."

$msbuildExe = "$env:windir\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
if(!(Test-Path $msbuildExe))
{
    echo "MSBuild not found at $msbuildExe"
    exit 1
}

&$msbuildExe $InstallDirectory\install.proj /target:"Dynamic" /filelogger /fileloggerparameters:"LogFile=$LogDirectory\install.log"