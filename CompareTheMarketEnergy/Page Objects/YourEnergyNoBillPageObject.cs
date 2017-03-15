using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheMarketEnergy
{
    class YourEnergyNoBillPageObject
    {
        // YourEnergyNoBillPageObject Constructor
        public YourEnergyNoBillPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // Do you use a pre-payment meter?
        // Yes, I use a pre-payment meter
        [FindsBy(How = How.XPath, Using = ".//*[@id='prepay-yes-no']/div/div/label[1]/span")]
        public IWebElement optUsePrepaymentMeter { get; set; }

        // No, I do not use a pre-payment meter
        [FindsBy(How = How.XPath, Using = ".//*[@id='prepay-yes-no']/div/div/label[2]/span")]
        public IWebElement optDoNotUsePrepaymentMeter { get; set; }

        // Do you have an Economy 7 meter?
        // "Yes, I have an Economy 7 meter?
        //[FindsBy(How = How.Id, Using = "economy-7-yes")]
        [FindsBy(How = How.XPath, Using = ".//*[@id='economy-7-question']/div/div/label[1]/span")]
        public IWebElement optUseEconomySeven { get; set; }

        // "No, I do not have an Economy 7 meter?
        //[FindsBy(How = How.Id, Using = "economy-7-no")]
        [FindsBy(How = How.XPath, Using = ".//*[@id='economy-7-question']/div/div/label[2]/span")]
        public IWebElement optDoNotUseEconomySeven { get; set; }

        // How much do you currently spend on electricity?
        // Electricity current spend amount
        [FindsBy(How = How.XPath, Using = ".//*[@id='electricity-current-spend']")]
        public IWebElement txtElectricityCurrentSpend { get; set; }

        // Electricity current spend period
        [FindsBy(How = How.XPath, Using = ".//*[@id='electricity-current-spend-period']")]
        public IWebElement ddlElectricityCurrentSpendPeriod { get; set; }

        // I don't know
        [FindsBy(How = How.XPath, Using = ".//*[@id='electricity-dont-know-check']")]
        public IWebElement chkDontKnowCurrentElectricitySpend { get; set; }

        // How much do you currently spend on gas?
        // Gas current spend amount
        [FindsBy(How = How.XPath, Using = ".//*[@id='gas-current-spend']")]
        public IWebElement txtGasCurrentSpend { get; set; }

        // Gas current spend period
        [FindsBy(How = How.XPath, Using = ".//*[@id='gas-current-spend-period']")]
        public IWebElement ddlGasCurrentSpendPeriod { get; set; }

        // I don't know
        [FindsBy(How = How.XPath, Using = ".//*[@id='gas-dont-know-check']")]
        public IWebElement chkDontKnowCurrentGasSpend { get; set; }

        // Next Button
        [FindsBy(How = How.XPath, Using = ".//*[@id='goto-your-energy']")]
        public IWebElement btnNext { get; set; }

        public YourDetailsPageObject SubmitEnergyDetails()
        {
            // Wait 5 Seconds
            System.Threading.Thread.Sleep(5000);

            // Click Next button
            SeleniumSetMethods.Click(btnNext);

            // Return the page object
            return new YourDetailsPageObject();
        }
    }
}
