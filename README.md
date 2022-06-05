Source: https://www.youtube.com/watch?v=5YB49OEmbbE
==> Commands:
1. dotnet add package Microsoft.EntityFrameworkCore
2. dotnet add package Microsoft.EntityFrameworkCore.Design
3. dotnet add package Microsoft.EntityFrameworkCore.SqlServer
4. dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
====
1. dotnet user-secrets init


====
1. dotnet user-secrets set "UserId" "SA"
2. dotnet user-secrets set "Password" "Ashikur123@"


====
1. dotnet ef migrations add initialmigration -v
   [only if you get an error]
   => dotnet tool install --global dotnet-ef 
2. dotnet ef database update


===
1. dotnet build
2. dotnet watch