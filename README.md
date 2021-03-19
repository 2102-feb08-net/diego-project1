# GameZone Store
Markup :  # Project Description #
GameZone Store is a webstore targeted at videogame retailers, with customer oriented navigation. Customers are able to register and login to the webstore. 
Customers can also check products managed at the central store, and the three main locations. The products for the stores and locations are loaded from 
a separate SQL database.
Markup :  # Technologies #
 Markup : * C#
          * SQL Server
          * Entitiy Framework
          * HTML
          * JavaScript
          * Bootstrap 4.6.0
          * ASP .NET Web API
Markup :  # Features #
 Markup : * Customer can signup/register to the webstore.
          * Customer can login to the webstore.
          * Customer can see the products managed by the main store and the three main locations.
Markup :  To-do list:
 Markup : * Implement functionality to allow customer to select a product and quantity after choosing a location from which to buy.
          * Implement functionality to add selected products to a cart.
          * Implement functionality to checkout products in cart.
Markup :  # Getting started #
Markup : Use the command 'git clone' as shown below to copy the project from the repository. 
 Markup : * git clone https://github.com/2102-feb08-net/diego-project1.git
Markup : Create a SQL Database and an App Service in Azure Portal.
Markup : Copy the connection string from the SQL Database and add it to the connection strings in the App Service Configuration.
Markup : Open Microsoft SQL Server Management Studio and enter your credentials and SQL Database information.   
Markup : Use the file GZStore_Schema_v1.sql to create the databse schema.
Markup : Open the project solution in Visual Studio.
Markup : Right click on Store.WebUI project and select the option 'Manage User Secrets.'
Markup : Add the database connection string to the user secrets.
Markup : Right-click on Store.WebUI project and select the option 'Publish.'
Markup : Follow the instructions and select your App Service when prompted.
Markup : Click on 'Publish' to launch the website.
Markup : Alternatively, the link below will lead you to the website.
Markup : * https://2102-rincon-gzstore.azurewebsites.net/index.html
         * NOTE: The website will not be available if the App Service it stopped.
Markup :  # Usage #
Markup : * On the navigation bar click on 'SignIn' and fill-in all fields to register to the store.
             * On completion, a popup will be displayed to notify that signup was successful.
Markup : * On the navigation bar click on 'LogIn' and enter your email and password.
Markup : * On the navigation bar click on 'Location' and select any of the three locations to load its managed products.
