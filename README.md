# GameZone Store
# Project Description #
GameZone Store is a webstore targeted at videogame retailers, with customer oriented navigation. Customers are able to register and login to the webstore. 
Customers can also check products managed at the central store, and the three main locations. The products for the stores and locations are loaded from 
a separate SQL database.

# Technologies #
* C#
* SQL Server
* Entitiy Framework
* HTML
* JavaScript
* Bootstrap 4.6.0
* ASP .NET Web API
# Features #
* Customer can signup/register to the webstore.
* Customer can login to the webstore.
* Customer can see the products managed by the main store and the three main locations.

To-do list:
* Implement functionality to allow customer to select a product and quantity after choosing a location from which to buy.
* Implement functionality to add selected products to a cart.
* Implement functionality to checkout products in cart.

# Getting started #
Use the command 'git clone' as shown below to copy the project from the repository. 
* git clone https://github.com/2102-feb08-net/diego-project1.git

Create a SQL Database and an App Service in Azure Portal.
Copy the connection string from the SQL Database and add it to the connection strings in the App Service Configuration.
Open Microsoft SQL Server Management Studio and enter your credentials and SQL Database information.   
Use the file GZStore_Schema_v1.sql to create the databse schema.
Open the project solution in Visual Studio.
Right click on Store.WebUI project and select the option 'Manage User Secrets.'
Add the database connection string to the user secrets.
Right-click on Store.WebUI project and select the option 'Publish.'
Follow the instructions and select your App Service when prompted.
Click on 'Publish' to launch the website.
Alternatively, the link below will lead you to the website.
* https://2102-rincon-gzstore.azurewebsites.net/index.html
* NOTE: The website will not be available if the App Service it stopped.

# Usage #
* On the navigation bar click on 'SignIn' and fill-in all fields to register to the store.
   * On completion, a popup will be displayed to notify that signup was successful.
* On the navigation bar click on 'LogIn' and enter your email and password.
* On the navigation bar click on 'Location' and select any of the three locations to load its managed products.
