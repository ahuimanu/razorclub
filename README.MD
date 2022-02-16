dotnet new xunit -o webapp.Tests

dotnet tool install --global dotnet-aspnet-codegenerator

dotnet aspnet-codegenerator razorpage -m Student -dc webapp.Data.RazorClubContext -udl -outDir Pages/Students --referenceScriptLibraries -sqlite


dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.InMemory
