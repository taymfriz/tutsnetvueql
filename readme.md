task
https://www.youtube.com/watch?v=qjJoZCN6X0I

>> add efcore
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.5



>> add reference
dotnet add [<PROJECT>] reference [-f|--framework <FRAMEWORK>]
     [--interactive] <PROJECT_REFERENCES>

dotnet add reference -h|--help



# DATABASE
>> if ef tools is not installed, install it dummy 
```terminal
dotnet tool install --global dotnet-ef
```

# Update DB base on updated model (using terminal)
```terminal
set ASPNETCORE_ENVIRONMENT=Development

dotnet ef migrations add InitMigrationsNameHere  --verbose --startup-project ../GoodBooks.Web/

dotnet ef database update  --verbose --startup-project ../GoodBooks.Web/

```



