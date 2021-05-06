task
https://www.youtube.com/watch?v=qjJoZCN6X0I

>> add efcore
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.5



>> add reference
dotnet add [<PROJECT>] reference [-f|--framework <FRAMEWORK>]
     [--interactive] <PROJECT_REFERENCES>

dotnet add reference -h|--help



##DATABASE
>> dotnet tool install --global dotnet-ef

>> dotnet ef database update -- --environment Development
>> dotnet ef database update -- --environment Production

>> dotnet ef database update InitialCreate
