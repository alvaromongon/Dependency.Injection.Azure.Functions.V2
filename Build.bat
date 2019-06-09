@echo Off
set config=%1
if "%config%" == "" (
   set config=Release
)

REM Build
dotnet build Microsoft.Azure.Functions.V2.DI.sln --configuration %config%

REM Package
mkdir Build
call nuget pack -OutputDirectory Build Microsoft.Azure.Functions.V2.DI.nuspec