Note: 
      - ExitTest->Backend ,
      - FinalExitTest-->Frontend

# Grocery Application


The Grocery Application is a web-based application that allows users to browse and purchase groceries online. This README provides an overview of the application and its components, along with instructions for setting up and running the application.

## Features

The Grocery Application offers the following features:

- User sigIn and signUp
- Product browsing and search functionality
- Shopping add to cart management
- Order placement 
- Admin dashboard for managing products, inventory, and orders

## Technologies Used

The Grocery Application utilizes the following technologies:

- Angular: A popular JavaScript framework for building the frontend.
- ASP.NET: A web development framework used for building the backend.
- Database (DB) first approach: A development methodology where the database schema is designed first, and the code is generated based on the database structure.

## Prerequisites

Before setting up the Grocery Application, make sure you have the following prerequisites installed:

- Node.js: The latest LTS version of Node.js is required to run Angular.
- .NET SDK: Install the latest .NET SDK to run the ASP.NET backend.
- Microsoft SQL Server: Set up a SQL Server instance or have access to an existing SQL Server.

## Installation

To install and set up the Grocery Application, follow these steps:

1. Clone the repository from Github:

   shell
   git clone (https://github.com/hrtzrahul/GroceryStoreApp)

2. Change into the project directory:

    shell
    cd ExitTest

3. Install the frontend dependencies:
    shell
    cd ExitTest
    npm install

4. Install the backend dependencies:
    shell
    cd ../FinalExitTest
    dotnet restore

## Configuration

Before running the application, you need to configure the database connection. Follow these steps:

1. Open the Tools section VS Studio -> Nuget Package Manager -> Package Manager Console.

2. Run update-database command.

## Dependencies

1. Add dependencies for UI in package.json
   - "@fortawesome/angular-fontawesome": "^0.13.0",
   - "@fortawesome/fontawesome-svg-core": "^6.4.0",
   - "@fortawesome/free-solid-svg-icons": "^6.4.0",
   - "bootstrap": "^5.3.0",

## Running the Application

To run the Grocery Application, follow these steps:

1. Start the backend server:

   shell
   cd ExitTest
   dotnet run

2. Start the frontend development server:
    shell
    cd FinalExitTest
    ng serve

The frontend development server should now be running on http://localhost:4200.

3. Go to appsettings.development. in backend solution folder json find the admin credentials

"AppSettings": {

"UserName": "admin",

"UserEmail": "myadmin@test.com",

"UserPassword": "Test@321",

"AdminUserEmail": "myadmin@test.com"

}

## Usage
To use the Grocery Application, open your web browser and navigate to http://localhost:4200. You should see the application's homepage, where you can log in to access the full features of the application.
