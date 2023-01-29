# CustomerTransactionApp
For calculating end of day balances

How to setup and run the project
================================

Download the project from github - https://github.com/frankewans/CustomerTransactionApp

Open in Visual Studio (preferrably 2022)

Build the project

Make sure Docker Desktop is installed and running

Open a new terminal in Visual Studio at the root directory (C:\Users\<user>\Documents\Visual Studio 2022\Projects\DevOps\CustomerTransactionApp>)

run docker build -t customertransaction .

run docker run -it --rm -p 8080:80 customertransaction

Open your browser and paste/type http://localhost:8080

The landing page is displaying a list of customers (rather than assuming its just a single customer, this approach makes it extensible)

Once the list of users are displayed on the table, select "View Transactions". This will route you to the Details page. Select a date from the calendar and click on "Submit" to view the end-of-day balances and transaction details


Project design
==============

Built using .Net6

The design pattern is Domain Driven Design

UI is ASP.Net core razor view

Adheres to the principles of OOP - Classes, Interfaces, Inheritance, encapsulation, abstraction etc.

The code was KISS, DRY, YAGNI and adhered to the SOLID principle

There is an error page that handles all exceptions


Project Structure
=================

There are 2 main projects in the solution (CustomerTransaction and CustomerTransactionApp.Service).

The CustomerTransactionApp.Service is the Business Logic and Data Access Layer while the former is the main application


