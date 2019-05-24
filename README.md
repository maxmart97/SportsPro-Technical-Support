## SportsPro Technical Support

This application serves as a mock technical support program. I developed this program in parts for my Visual Programming II class during the fall 2018 
semester.

This application was created using Visual Studio, and it uses a database that I loaded onto a free GearHost SQL Server instance.

This application uses ADO.NET and LINQ to SQL. Use of LINQ to SQL as object data sources vs. model classes as object data sources varies. It depends on 
the 
point in the semester each part of the application was developed and which functionality I preferred to use at various times. Because LINQ to SQL object 
names overlap with names of model classes in the BLL (Business Logic Layer), I have to use the elaborated name of objects in certain scenarios. Ex: 
List<SportsProBLL.Customer> 
vs. List<SportsProUserInterface.Customer> (First format is when using model class object data sources and second format is when using LINQ to SQL object 
data sources.) Lastly, the LINQ to SQL .dbml file was created in the SportsProUserInterface namespace.

01/24/2019: All general functionality is complete. However, LINQ to SQL queries load slowly. Optimization needed.

## Download

1. Go to: /SportsProSetupProject/Release/SportsProSetupProject.msi
2. Download the .msi file and run it. It will take you through a Windows installer and install the program to your computer.
