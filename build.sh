dotnet restore SofiAssignment.sln
dotnet build SofiAssignment.sln -f net46
dotnet test SofiAssignment.Tests/SofiAssignment.Tests.csproj -f net46