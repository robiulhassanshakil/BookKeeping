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


## API Endpoints
The following endpoints are available in the BookKeeping API:

### POST /api/BookKeeping
The POST /api/BookKeeping endpoint allows users to submit financial data for a given year. The payload for this endpoint should be in the following format:
```
  {
  "year": 2020,
  "totalIncome": 100000,
  "monthlyIncomes": [
    {
      "month": 1,
      "income": 100
    },
    {
      "month": 2,
      "income": 200
    },
    {
      "month": 3,
      "income": 300
    },
    {
      "month": 4,
      "income": 100
    },
    {
      "month": 5,
      "income": 200
    },
    {
      "month": 6,
      "income": 100
    },
    {
      "month": 7,
      "income": 300
    },
    {
      "month": 8,
      "income": 200
    },
    {
      "month": 9,
      "income": 100
    },
    {
      "month": 10,
      "income": 100
    },
    {
      "month": 11,
      "income": 200
    },
    {
      "month": 12,
      "income": 200
    }
  ],
  "monthlyCosts": [
    {
      "month": 1,
      "cost": 100
    },
    {
      "month": 2,
      "cost": 300
    },
    {
      "month": 3,
      "cost": 100
    },
    {
      "month": 4,
      "cost": 200
    },
    {
      "month": 5,
      "cost": 100
    },
    {
      "month": 6,
      "cost": 200
    },
    {
      "month": 7,
      "cost": 100
    },
    {
      "month": 8,
      "cost": 100
    },
    {
      "month": 9,
      "cost": 200
    },
    {
      "month": 10,
      "cost": 300
    },
    {
      "month": 11,
      "cost": 100
    },
    {
      "month": 12,
      "cost": 100
    }
  ],
  "incomeDynamics": [
    {
      "incomeName": "type1",
      "incomeValueJson": "[{\"month\":1,\"income\":0},{\"month\":2,\"income\":0},{\"month\":3,\"income\":0},{\"month\":4,\"income\":0},{\"month\":5,\"income\":0},{\"month\":6,\"income\":100},{\"month\":7,\"income\":160},{\"month\":8,\"income\":0},{\"month\":9,\"income\":0},{\"month\":10,\"income\":0},{\"month\":11,\"income\":0},{\"month\":12,\"income\":100}]"
    },
    {
      "incomeName": "type2",
      "incomeValueJson": "[{\"month\":1,\"income\":0},{\"month\":2,\"income\":0},{\"month\":3,\"income\":120},{\"month\":4,\"income\":130},{\"month\":5,\"income\":0},{\"month\":6,\"income\":0},{\"month\":7,\"income\":0},{\"month\":8,\"income\":0},{\"month\":9,\"income\":0},{\"month\":10,\"income\":0},{\"month\":11,\"income\":200},{\"month\":12,\"income\":100}]"
    },
    {
      "incomeName": "type3",
      "incomeValueJson": "[{\"month\":1,\"income\":0},{\"month\":2,\"income\":0},{\"month\":3,\"income\":120},{\"month\":4,\"income\":0},{\"month\":5,\"income\":0},{\"month\":6,\"income\":0},{\"month\":7,\"income\":100},{\"month\":8,\"income\":0},{\"month\":9,\"income\":0},{\"month\":10,\"income\":190},{\"month\":11,\"income\":0},{\"month\":12,\"income\":0}]"
    },
    {
      "incomeName": "type4",
      "incomeValueJson": "[{\"month\":1,\"income\":100},{\"month\":2,\"income\":0},{\"month\":3,\"income\":0},{\"month\":4,\"income\":0},{\"month\":5,\"income\":140},{\"month\":6,\"income\":150},{\"month\":7,\"income\":0},{\"month\":8,\"income\":0},{\"month\":9,\"income\":180},{\"month\":10,\"income\":0},{\"month\":11,\"income\":0},{\"month\":12,\"income\":0}]"
    }
  ],
  "costDynamics": [
    {
      "costName": "type1",
      "costValueJson": "[{\"month\":1,\"cost\":0},{\"month\":2,\"cost\":0},{\"month\":3,\"cost\":120},{\"month\":4,\"cost\":130},{\"month\":5,\"cost\":0},{\"month\":6,\"cost\":150},{\"month\":7,\"cost\":0},{\"month\":8,\"cost\":0},{\"month\":9,\"cost\":0},{\"month\":10,\"cost\":190},{\"month\":11,\"cost\":200},{\"month\":12,\"cost\":210}]"
    },
    {
      "costName": "type2",
      "costValueJson": "[{\"month\":1,\"cost\":0},{\"month\":2,\"cost\":0},{\"month\":3,\"cost\":120},{\"month\":4,\"cost\":0},{\"month\":5,\"cost\":140},{\"month\":6,\"cost\":150},{\"month\":7,\"cost\":160},{\"month\":8,\"cost\":170},{\"month\":9,\"cost\":0},{\"month\":10,\"cost\":0},{\"month\":11,\"cost\":0},{\"month\":12,\"cost\":210}]"
    },
    {
      "costName": "type3",
      "costValueJson": "[{\"month\":1,\"cost\":100},{\"month\":2,\"cost\":110},{\"month\":3,\"cost\":0},{\"month\":4,\"cost\":130},{\"month\":5,\"cost\":140},{\"month\":6,\"cost\":150},{\"month\":7,\"cost\":160},{\"month\":8,\"cost\":0},{\"month\":9,\"cost\":0},{\"month\":10,\"cost\":100},{\"month\":11,\"cost\":0},{\"month\":12,\"cost\":0}]"
    }
  ]
}  
 ```
