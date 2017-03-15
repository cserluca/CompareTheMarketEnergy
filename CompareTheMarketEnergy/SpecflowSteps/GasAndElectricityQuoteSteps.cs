using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CompareTheMarketEnergy
{
    [Binding]
    public sealed class GasAndElectricityQuoteSteps
    {
        [Given(@"I am on the your supplier page for a gas and electricity quote")]
        public void GivenIAmOnTheYourSupplierPageForAGasAndElectricityQuote()
        {
            // Open Chrome browser
            PropertiesCollection.driver = new ChromeDriver();

            // Navigate to CTM Energy page
            PropertiesCollection.driver.Navigate().GoToUrl("https://energy.comparethemarket.com/energy/v2/?AFFCLIE=TSTT");

            // Create new instance of YourSupplierPageObject()
            YourSupplierPageObject yourSupplierPage = new YourSupplierPageObject();

            // Verify that Your Supplier page is open by searching for page heading
            Assert.AreEqual("Your Supplier", PropertiesCollection.driver.FindElement(By.CssSelector("h2.main-heading")).Text);
        }

        [Given(@"I enter a postcode for for a gas and electricity quote")]
        public void GivenIEnterAPostcodeForForAGasAndElectricityQuote()
        {
            // Create new instance of YourSupplierPageObject()
            YourSupplierPageObject yourSupplierPage = new YourSupplierPageObject();

            // Enter postcode PE2 6YS
            yourSupplierPage.txtPostCode.SendKeys("PE2 6YS");

            // Click on Find Postcode button
            yourSupplierPage.btnFindPostCode.Click();
        }

        [Given(@"I do not have my bill handy for a gas and electricity quote")]
        public void GivenIDoNotHaveMyBillHandyForAGasAndElectricityQuote()
        {
            // Create new instance of YourSupplierPageObject()
            YourSupplierPageObject yourSupplierPage = new YourSupplierPageObject();

            // I do not have your bill handy
            yourSupplierPage.optDoNotHaveBill.Click();
        }

        [Given(@"I want to compare price quotes for gas and electricity for a gas and electricity quote")]
        public void GivenIWantToComparePriceQuotesForGasAndElectricityForAGasAndElectricityQuote()
        {
            // Create new instance of YourSupplierPageObject()
            YourSupplierPageObject yourSupplierPage = new YourSupplierPageObject();

            // What do you want to compare?
            // Specify either "GasElectricity", "ElectricityOnly" or "GasOnly"
            yourSupplierPage.EnergyToCompare("GasElectricity");
        }

        [Given(@"I do not know who supplies my electricity for a gas and electricity quote")]
        public void GivenIDoNotKnowWhoSuppliesMyElectricityForAGasAndElectricityQuote()
        {
            // Create new instance of YourSupplierPageObject()
            YourSupplierPageObject yourSupplierPage = new YourSupplierPageObject();

            // I do not know Who supplies my electricity
            yourSupplierPage.ElectricitySupplierUnknown();
        }

        [Given(@"I do not know who supplies my gas for a gas and electricity quote")]
        public void GivenIDoNotKnowWhoSuppliesMyGasForAGasAndElectricityQuote()
        {
            // Create new instance of YourSupplierPageObject()
            YourSupplierPageObject yourSupplierPage = new YourSupplierPageObject();

            // I do not know Who supplies my gas
            yourSupplierPage.GasSupplierUnknown();
        }

        [Given(@"I click next on the your supplier page for a gas and electricity quote")]
        public void GivenIClickNextOnTheYourSupplierPageForAGasAndElectricityQuote()
        {
            // Create new instance of YourSupplierPageObject()
            YourSupplierPageObject yourSupplierPage = new YourSupplierPageObject();

            // Submit details entered on Your Supplier Page
            YourEnergyNoBillPageObject yourEnergyNoBillPage = yourSupplierPage.SubmitSupplierDetails();

            // Wait for Your Energy page to open by searching for page heading
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 1, 0));
            wait.Until(d => d.FindElement(By.CssSelector("h1.main-heading")));

            // Verify that Your Energy page is open by searching for page heading
            Assert.AreEqual("Your Energy", PropertiesCollection.driver.FindElement(By.CssSelector("h1.main-heading")).Text);
        }

        [Given(@"I do not use a prepayment meter for a gas and electricity quote")]
        public void GivenIDoNotUseAPrepaymentMeterForAGasAndElectricityQuote()
        {
            // Create new instance of YourEnergyNoBillPageObject()
            YourEnergyNoBillPageObject yourEnergyNoBillPage = new YourEnergyNoBillPageObject();

            // I do not use a prepayment meter?
            yourEnergyNoBillPage.optDoNotUsePrepaymentMeter.Click();
        }

        [Given(@"I do not have an EconomySeven meter for a gas and electricity quote")]
        public void GivenIDoNotHaveAnEconomySevenMeterForAGasAndElectricityQuote()
        {
            // Create new instance of YourEnergyNoBillPageObject()
            YourEnergyNoBillPageObject yourEnergyNoBillPage = new YourEnergyNoBillPageObject();

            // I do not have an Economy 7 meter?
            yourEnergyNoBillPage.optDoNotUseEconomySeven.Click();
        }

        [Given(@"I enter how much I currently spend on electricity each month for a gas and electricity quote")]
        public void GivenIEnterHowMuchICurrentlySpendOnElectricityEachMonthForAGasAndElectricityQuote()
        {
            // Create new instance of YourEnergyNoBillPageObject()
            YourEnergyNoBillPageObject yourEnergyNoBillPage = new YourEnergyNoBillPageObject();

            // Enter a monthly (selected by default) spend on electricity of £50
            yourEnergyNoBillPage.txtElectricityCurrentSpend.SendKeys("50");
        }

        [Given(@"I enter how much I currently spend on gas each month for a gas and electricity quote")]
        public void GivenIEnterHowMuchICurrentlySpendOnGasEachMonthForAGasAndElectricityQuote()
        {
            // Create new instance of YourEnergyNoBillPageObject()
            YourEnergyNoBillPageObject yourEnergyNoBillPage = new YourEnergyNoBillPageObject();

            // Enter a monthly (selected by default) spend on gas of £50
            yourEnergyNoBillPage.txtGasCurrentSpend.SendKeys("50");
        }

        [Given(@"I click Next on the your energy page for a gas and electricity quote")]
        public void GivenIClickNextOnTheYourEnergyPageForAGasAndElectricityQuote()
        {
            // Create new instance of YourEnergyNoBillPageObject()
            YourEnergyNoBillPageObject yourEnergyNoBillPage = new YourEnergyNoBillPageObject();

            // Submit details entered on Your Energy No Bill Page
            YourDetailsPageObject yourDetailsPage = yourEnergyNoBillPage.SubmitEnergyDetails();

            // Wait for Your Details page to open by searching for page heading
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 1, 0));
            wait.Until(d => d.FindElement(By.XPath("html/body/div/div/main/div/div/h2")));

            // Verify that Your Details page is open by searching for page heading
            Assert.AreEqual("Your Preferences", PropertiesCollection.driver.FindElement(By.XPath("html/body/div/div/main/div/div/h2")).Text);
        }

        [Given(@"I am interested in all tariffs for a gas and electricity quote")]
        public void GivenIAmInterestedInAllTariffsForAGasAndElectricityQuote()
        {
            // Create new instance of YourDetailsPageObject()
            YourDetailsPageObject yourDetailsPage = new YourDetailsPageObject();

            // I am interested in all tariffs
            yourDetailsPage.optAllTariff.Click();
        }

        [Given(@"I am interested in all payment types for for a gas and electricity quote")]
        public void GivenIAmInterestedInAllPaymentTypesForForAGasAndElectricityQuote()
        {
            // Create new instance of YourDetailsPageObject()
            YourDetailsPageObject yourDetailsPage = new YourDetailsPageObject();

            // I am interested in all payment types
            yourDetailsPage.optAllPaymentTypes.Click();
        }

        [Given(@"I enter my email address for for a gas and electricity quote")]
        public void GivenIEnterMyEmailAddressForForAGasAndElectricityQuote()
        {
            // Create new instance of YourDetailsPageObject()
            YourDetailsPageObject yourDetailsPage = new YourDetailsPageObject();

            //Enter my email address
            yourDetailsPage.txtEmail.SendKeys("cserluca@hotmail.com");
        }

        [Given(@"I agree to product and marketing information via email for a gas and electricity quote")]
        public void GivenIAgreeToProductAndMarketingInformationViaEmailForAGasAndElectricityQuote()
        {
            // Create new instance of YourDetailsPageObject()
            YourDetailsPageObject yourDetailsPage = new YourDetailsPageObject();

            // I agree that comparethemarket.com can keep me up to date with the latest product and marketing information via email
            yourDetailsPage.chkMarketing.Click();
        }

        [Given(@"I have read and understood the website terms and conditions for a gas and electricity quote")]
        public void GivenIHaveReadAndUnderstoodTheWebsiteTermsAndConditionsForAGasAndElectricityQuote()
        {
            // Create new instance of YourDetailsPageObject()
            YourDetailsPageObject yourDetailsPage = new YourDetailsPageObject();

            // I confirm you have read and understood our website Terms & Conditions
            yourDetailsPage.chkTermsAndConditions.Click();
        }

        [When(@"I click Go to prices for a gas and electricity quote")]
        public void WhenIClickGoToPricesForAGasAndElectricityQuote()
        {
            // Create new instance of YourDetailsPageObject()
            YourDetailsPageObject yourDetailsPage = new YourDetailsPageObject();

            // Submit details entered on Your Details Page
            YourResultsPageObject yourResultsPage = yourDetailsPage.SubmitDetails();

            // Wait for Your Results page to open by searching for page heading
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 1, 0));
            wait.Until(d => d.FindElement(By.XPath("html/body/div/div/main/section[3]/h2")));
        }

        [Then(@"I will see the your results page for a gas and electricity quote")]
        public void ThenIWillSeeTheYourResultsPageForAGasAndElectricityQuote()
        {
            // Create new instance of YourResultsPageObject()
            YourResultsPageObject yourResultsPage = new YourResultsPageObject();

            // Verify that Your Results page is open by searching for page heading
            Assert.AreEqual("Your Results", PropertiesCollection.driver.FindElement(By.XPath("html/body/div/div/main/section[3]/h2")).Text);

            // Get price data from results table and log to test output
            SeleniumGetMethods.GetTableData();

            // Close browser
            PropertiesCollection.driver.Close();
        }
    }
}