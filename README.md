1. Clone repository project
2. With Visual Studio open project , select APIChaning.sln
3. Click on the Debug button
4. Check Output window
   
Example:

Pet Created: {"id":28041981,"name":"Fluffy","photoUrls":[],"tags":[],"status":"available"}
Retrieved Pet: {"id":28041981,"name":"Fluffy","photoUrls":[],"tags":[],"status":"available"}
Updated Pet: {"id":28041981,"name":"Fuzzy","photoUrls":[],"tags":[],"status":"available"}
Deleted Pet: {"code":200,"type":"unknown","message":"28041981"}

With Command line commands:

1. Prerequisite: Install .NET 8 Runtime https://dotnet.microsoft.com/en-us/download/dotnet/8.0
2. git clone https://github.com/systemteam7150/APIChaning.git
3. cd APIChaning
4. dotnet restore
5. dotnet build
6. dotnet run
