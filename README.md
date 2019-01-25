# SportsPro_Application

This application serves as a mock technical support program. I developed this program in parts for my programming class during the fall 2018 semester and have been continually adding to it.

The application runs in Visual Studio, and it uses a database that I loaded onto a free GearHost SQL Server instance. 

This application uses ADO.NET and LINQ to SQL. Use of LINQ to SQL as object data sources vs. model classes as object data sources varies depending on the point in the semester each part of the application was developed and which functionality I preferred to use at various times. Because LINQ to SQL object names overlap with names of model classes in the BLL, I have to use the elaborated name of objects in certain scenarios. Ex: List<SportsProBLL.Customer> vs. List<SportsProUserInterface.Customer> (First is for model class object data sources and second is LINQ to SQL object data sources.) The LINQ to SQL .dbml file was created in the SportsProUserInterface namespace.

01/24/2018: All general functionality is complete. However, data is not loading very fast. I need to do an edit of all the code to see where I can do some optimization. I also need to do an edit 
for consistency and unnecessary code. I am back in school for the spring semester and will be working on JavaScript stuff for my web development class. I will optimize and edit if I get a chance. This project is basically complete.
