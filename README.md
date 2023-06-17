

PaySky Employment System
Overview
This project is a .NET Core solution with a SQL Server database. The project uses the Code First approach to generate the database schema from C# classes.

Prerequisites
Before running the project, ensure that you have the following installed on your system:

.NET Core SDK 
SQL Server 

Getting Started
To get started with the project, follow these steps:

1- Clone the repository from GitHub:
  https://github.com/PoulaAshraf/EmploymentPaySkySystem
2- Open the project in Visual Studio 2022
3- Update the connection string in the appsettings.json file to point to your SQL Server instance:
  {
  "ConnectionStrings": {
    "MyDbContext": "Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
  }

  Replace (localdb)\\mssqllocaldb with the name of your SQL Server instance and MyDatabase with the name of your database.
4- Run the following command in the Nuget Package Console to create the database 
  update-database 
  Note: Migration files attached in project, don't forget to change default project to data when migrating files 
5- Please make sure you called Request: http://localhost:27999/api/Vacancy/ArchiveExpiryVacancies to make sure that hangfire is working with it's dashboard. you can access to hang fire dashboard when goto http://localhost:27999/hangfire ,also don't forget to change to your port  
6- Project has Postman collection which has Request samples and its response 

Note: The main Solution's named EmploymentApi to run project successfully 
