using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheMarketEnergy
{
    class YourDetailsPageObject
    {
        // YourDetailsPageObject Constructor
        public YourDetailsPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // Your Preferences Section
        // What tariff are you interested in?
        // Fixed tariff
        [FindsBy(How = How.XPath, Using = ".//*[@id='tariff-selection-question']/div/label[1]/span/span")]
        public IWebElement optFixedTariff { get; set; }

        // Variable tariff
        [FindsBy(How = How.XPath, Using = ".//*[@id='tariff-selection-question']/div/label[2]/span/span")]
        public IWebElement optVariableTariff { get; set; }

        // All tariffs
        [FindsBy(How = How.XPath, Using = ".//*[@id='tariff-selection-question']/div/label[3]/span/span")]
        public IWebElement optAllTariff { get; set; }

        
        // What payment type are you interested in?
        // Monthly direct debit
        [FindsBy(How = How.XPath, Using = ".//*[@id='payment-selection-question']/div/label[1]/span/span")]
        public IWebElement optMonthlyDirectDebit { get; set; }

        // Quarterly direct debit
        [FindsBy(How = How.XPath, Using = ".//*[@id='payment-selection-question']/div/label[2]/span/span")]
        public IWebElement optQuarterlyDirectDebit { get; set; }

        // Pay on receipt of bill
        [FindsBy(How = How.XPath, Using = ".//*[@id='payment-selection-question']/div/label[3]/span/span")]
        public IWebElement optPayOnReceiptOfBill { get; set; }

        // All payment types
        [FindsBy(How = How.XPath, Using = ".//*[@id='payment-selection-question']/div/label[4]/span/span")]
        public IWebElement optAllPaymentTypes { get; set; }


        // Your Contact Details Section
        // What is your email address?
        [FindsBy(How = How.XPath, Using = ".//*[@id='Email']")]
        public IWebElement txtEmail { get; set; }

        // Product and marketing information via email checkbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='marketingT']/div/div[2]/label/span[2]")]
        public IWebElement chkMarketing { get; set; }

        //  Website Terms & Conditions checkbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='terms-label']/span[2]")]
        public IWebElement chkTermsAndConditions { get; set; }
        
        
        // "Go to prices" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='email-submit']")]
        public IWebElement btnGoToPrices { get; set; }

        public YourResultsPageObject SubmitDetails()
        {
            // Wait 5 Seconds
            System.Threading.Thread.Sleep(5000);

            // Click Next button
            SeleniumSetMethods.Click(btnGoToPrices);

            // Return the page object
            return new YourResultsPageObject();
        }
    }
}
