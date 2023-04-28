# BookKeeping

BookKeeping is a .NET 7 project that requires the .NET 7 SDK to run. This project helps users keep track of their financial transactions and provides a platform for managing financial data.

## Prerequisites
- .NET 7 SDK
- SQL Server 2019
- Access to the BookKeeping database backup file located in the `DatabaseBackup` folder.

## Setup
1. Clone the repository to your local machine.
2. Open the project in your preferred IDE.
3. Open the `appsettings.json` file and change the `DefaultConnection` string to the appropriate database connection string. 
    ```
    "DefaultConnection": "Server=.;Database=BookKeeping;User Id=sa;Password=12345678;TrustServerCertificate=True;"
    ```
4. Build and run the project.


## Restoring the Database
1. Open SQL Server Management Studio and connect to your database server.
2. Right-click on the `Databases` folder and select `Restore Database`.
3. Choose the option `Device` and click on the `...` button to navigate to the location of the backup file.
4. Select the backup file and click `OK`.
5. Click `OK` again to restore the database.
