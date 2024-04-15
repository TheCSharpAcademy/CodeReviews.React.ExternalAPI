# React.ExternalAPI

This is a website to view JDM cars. Each car has a picture, make, model, year of release and description.
The api is build with asp.net web api and the database runs on Sql server. The frontend is built with React and using Material UI.

# Installation
```
git clone https://github.com/mariusgrHiof/React.ExternalAPI.git
cd React.ExternalAPI
```

# To run the api
## Prepare the database
```
cd API/ExternalAPI
```
Make sure to add the corret connectionstring in the appsettings.Development.json.
```
  "ConnectionStrings": {
    "YourConnectionString": "Server=YourServerLocation;Database=CarDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
```
Update the database and run the api

```
dotnet ef database update
dotnet run
```

# To run the frontend
```
cd React.ExternalAPI/Frontend/client
npm install
npm start
```
