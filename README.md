
# Vendor & Order Tracker for Pierre's Bakery.

#### By _Seth Gonzales_

#### _An application to manage a list of vendors and their orders for Pierre's Bakery_

## Technologies Used

* HTML
* CSS
* Bootstrap
* C#
* .NET 6
* MSTest

## Description

This application organizes and builds a repository of vendors and their orders for Pierre's Bakery. Pierre can view a list of his vendors, select a vendor to view a list of their orders, and select an order to view its details. This project follows object oriented design with the vendor and order objects and is an the ASP.NET Core MVC application.

## Setup/Installation Requirements

* Navigate to repository for Pierre's Vendor and Order Tracker [GitHub](https://github.com/sethgonzales/PierresOrderTracker.Solution).
* Clone the repository down using `$ git clone https://github.com/sethgonzales/PierresOrderTracker.Solution.git` in your terminal.
* Navigate to this project's production directory called `PierresOrderTracker`.
* In the command line, run the command `$ dotnet run` to compile and execute the console application. 
   * To compile the console app without running it, use the following command: `$ dotnet build`.
* Create vendors and assign them orders. Watch as your list grows! Use navigational links for quick access to the Home page, or the list of vendors.
* To test the business logic, navigate to test directory, `PierresOrderTracker.Tests`.
   * In the command line, run the command `$ dotnet restore` to install any testing files.
   * In the command line, run the command `$ dotnet test` to execute the tests.

## Known Bugs

* Orders are cloned on order list page if user navigates quickly between the list and order form pages.


## MIT License

Copyright (c) 2023 Seth Gonzales

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Contact Information

If you run into any issues, or would like to contribute to our code, please email: sethgonzales157@gmail.com.