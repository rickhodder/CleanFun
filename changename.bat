REM Renames project and solution files - replace "CleanFun" with the 
REM new name for your projects and solution 
REM then rebuilds and runs web app
REM NOTE: no spaces! Ex. CleanFun instead of Clean Fun 

rename src\CleanArchitecture.Core\CleanArchitecture.Core.csproj CleanFun.Core.csproj
rename src\CleanArchitecture.Infrastructure\CleanArchitecture.Infrastructure.csproj CleanFun.Infrastructure.csproj
rename src\CleanArchitecture.SharedKernel\CleanArchitecture.SharedKernel.csproj CleanFun.SharedKernel.csproj
rename src\CleanArchitecture.Web\CleanArchitecture.Web.csproj CleanFun.Web.csproj 
rename tests\CleanArchitecture.FunctionalTests\CleanArchitecture.FunctionalTests.csproj CleanFun.FunctionalTests.csproj 
rename tests\CleanArchitecture.IntegrationTests\CleanArchitecture.IntegrationTests.csproj CleanFun.IntegrationTests.csproj 
rename tests\CleanArchitecture.Tests\CleanArchitecture.UnitTests.csproj CleanFun.UnitTests.csproj 

rename CleanArchitecture.sln CleanFun.sln
rename src\CleanArchitecture.Core CleanFun.Core
rename src\CleanArchitecture.Infrastructure CleanFun.Infrastructure
rename src\CleanArchitecture.SharedKernel CleanFun.SharedKernel  
rename src\CleanArchitecture.Web CleanFun.Web 

rename tests\CleanArchitecture.FunctionalTests CleanFun.FunctionalTests 
rename tests\CleanArchitecture.IntegrationTests CleanFun.IntegrationTests 
rename tests\CleanArchitecture.Tests CleanFun.UnitTests 


REM cd src\CleanFun.Web
REM dotnet build
REM dotnet run
REM cd ..\..