1. Clone repository project
2. With Visual Studio open project , select APIChaning.sln
3. Click on the Debug button
4. Check Output window
   
Example:

Pet Created: {"id":28041981,"name":"Fluffy","photoUrls":[],"tags":[],"status":"available"}
Retrieved Pet: {"id":28041981,"name":"Fluffy","photoUrls":[],"tags":[],"status":"available"}
Updated Pet: {"id":28041981,"name":"Fuzzy","photoUrls":[],"tags":[],"status":"available"}
Deleted Pet: {"code":200,"type":"unknown","message":"28041981"}

From command line:
git clone https://github.com/systemteam7150/APIChaning.git
cd APIChaning
dotnet restore
dotnet build
dotnet run
