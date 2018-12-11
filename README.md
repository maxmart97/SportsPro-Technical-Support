# SportsPro_Application

This application serves as a faux technical support program. I developed this program in parts for my programming class during the fall 2018 semester.

The application runs in Visual Studio, however it uses a database from an SQL Server that I have running on my local machine. Therefore, the program will not function properly without access to the server. I might try to put the database on a cloud SQL server at some point, but for now, the database is only on my computer.

This application uses ADO.NET, LINQ TO SQL, and object data sources. Use of LINQ to SQL vs. object data sources varies depending on the point in the semester when each part of the application was developed and which functionality I preferred to use at various times. Because LINQ to SQL object names overlap with names of model classes (for object data sources) in the BLL, I have to use the elaborated name of objects in certain scenarios. Ex: List<SportsProBLL.Customer> vs. List<SportsProUserInterface.Customer> (First is for object data sources and second is LINQ to SQL; The LINQ to SQL .dbml file was created in the SportsProUserInterface namespace.

12/01/2018: DEVELOPMENT STILL IN PROGRESS.
