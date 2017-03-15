# Compare The Market Energy Project

## Introduction
This test automation project was implemented to meet the requirements of the Comparethemarket.com SDET test.

This test automation project looks at the energy comparison journey:

https://energy.comparethemarket.com/energy/v2/?AFFCLIE=TSTT

As set out in the rules of the SDET test, three tests have been created in an attempt to provide the best coverage of the functionality that is possible.

## The Tests

The three tests that comprise this test automation project are:

ElectricityOnlyQuote

GasyOnlyQuote

GasAndElectricityQuote

Each of the tests above record all price comparison results from the Results page. This information can be viewed by clicking on the "Output" link within the Test Explorer window once each test has completed successfully.

### ElectricityOnlyQuote

This test follows an Electricity-Only energy price comparison journey from the "Your Supplier" page to the "Your Results" page. 

The selected options as part of this test are:

What is your postcode? = PE2 6YS
Do you have your bill handy? = No, I don’t have my bill
What do you want to compare? = Electricity only
Who supplies your electricity? = I don’t know
Do you use a pre-payment meter? = No
Do you have an Economy 7 meter? = No
How much do you currently spend on electricity? = £50 Monthly
What tariff are you interested in? = All tariffs
What payment type are you interested in? = All payment types

### GasyOnlyQuote

This test follows a Gas-Only energy price comparison journey from the "Your Supplier" page to the "Your Results" page. 

What is your postcode? = PE2 6YS
Do you have your bill handy? = No, I don’t have my bill
What do you want to compare? =  Gas only
Who supplies your gas? = I don’t know
Do you use a pre-payment meter? = No
How much do you currently spend on gas? = £50 Monthly
What tariff are you interested in? = All tariffs
What payment type are you interested in? = All payment types

### GasAndElectricityQuote

This test follows a Gas & Electricity energy price comparison journey from the "Your Supplier" page to the "Your Results" page. 

The selected options as part of this test are:

What is your postcode? = PE2 6YS
Do you have your bill handy? = No, I don’t have my bill
What do you want to compare? =  Gas & Electricity 
Who supplies your electricity? = I don’t know
Who supplies your gas? = I don’t know
Do you use a pre-payment meter? = No
Do you have an Economy 7 meter? = No
How much do you currently spend on electricity? = £50 Monthly
How much do you currently spend on gas? = £50 Monthly
What tariff are you interested in? = All tariffs
What payment type are you interested in? = All payment types

## Development Environment

This test automation project was completed in Visual Studio 2015 using the C# language and .NET framework version 4.6.1.

The packages used in the development environment are: 

NUnit version 3.6.1
Selenium.Support version 3.3.0
Selenium.WebDriver version 3.3.0
Selenium.WebDriver.ChromeDriver version 2.28.0
SpecFlow version 2.1.0
SpecFlow.NUnit version 2.1.0

## Test Framework

Selenium Webdriver has been used to automate the web browser testing function in this project. The target browser used in this project is Chrome.

There are some general helper classes included as part of the project. These provide various get and set methods used throughout the project. These classes can be found in the "General Classes" folder within the Microsoft Visual Studio Solution Explorer window.

A Page Object Model (POM) design has been implemented as part of the project in order to make code cleaner and easy to understand. Within the Microsoft Visual Studio Solution Explorer window the "Page Object" folder contains the page objects for the four pages forming part of the energy comparison journey:

YourSupplierPageObject.cs
YourEnergyNoBillPageObject.cs
YourDetailsPageObject.cs
YourResultsPageObject.cs

The Specflow framework has been used to define, manage and execute the tests in this project.

Within the Microsoft Visual Studio Solution Explorer window the "Specflow Features" folder contains the BDD Gherkin feature files:

ElectricityOnlyQuote.feature
GasyOnlyQuote.feature
GasAndElectricityQuote.feature

Within the Microsoft Visual Studio Solution Explorer window the "Specflow Steps" folder contains the C# step definition files:

ElectricityOnlyQuoteSteps.cs
GasyOnlyQuoteSteps.cs
GasAndElectricityQuoteSteps.cs

## Running The Tests

The tests can be run from the Microsoft Visual Studio Test Explorer window. This can be opened from the "Test" menu:

Test > Window > Test Explorer

From the Test Explorer window the three tests can be run together by selecting "Run All" or they can be run individually by right-clicking on the test(s) you wish to run and clicking on "Run Selected Tests" within the pop-up menu.
