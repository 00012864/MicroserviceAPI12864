# MicroserviceAPI12864
ASP.NET Core Web App

Inserting Excel or Csv file to sql server:
Please change the datatype of ID and ProductCategory to INT instead of tinyInt because the code is written based on the fields being an integer not a byte.
If the data (Id, CategoryID) gets imported as tinyint, the application ends up having errors because the methods in the application accept INT instead of byte/tinyint. 
Also, the price should be of type decimal(18, 10).


Products
The products.xlsx file is for inserting the products to sql server. When the Excel file gets saved as a CSV file and then imported to Sql Server, the product table should be created, along with the list of products. Howver, the foreign key query should be added after inserting the products list because it is necessary for showing the category of each product. 
If the products gets inserted through the CSV file, the query to create the products table is not needed.

Categories
The file for creating the categories table inludes the sql statements necessary to create the categories table and there is also the file with the sql queries to insert the list of categories. 
Both the queries for (creating the table and inserting the category values) should be executed.


Reminders:
When running the MICROSERVICE API application, please put /api/Product/1 after the localhost

MVC Application
When adding a new product, please enter ID that is not already in the products list because duplication is not allowed.
For new product, the product ID can be 31 and above but not below 31.
