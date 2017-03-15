using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheMarketEnergy
{
    class YourSupplierPageObject
    {
        public YourSupplierPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // What is your postcode?
        // Postcode Text Edit
        [FindsBy(How = How.XPath, Using = ".//*[@id='your-postcode']")]
        public IWebElement txtPostCode { get; set; }

        // Find postcode Button
        [FindsBy(How = How.XPath, Using = ".//*[@id='find-postcode']")]
        public IWebElement btnFindPostCode { get; set; }

        // Change postcode Button
        [FindsBy(How = How.XPath, Using = ".//*[@id='change-postcode']")]
        public IWebElement btnChangePostcode { get; set; }

        // Do you have your bill handy?
        // Yes, I have my bill Radio Button
        [FindsBy(How = How.XPath, Using = ".//*[@id='have-bill-label']/span")]
        public IWebElement optHaveBill { get; set; }

        // No, I don’t have my bill Radio Button
        [FindsBy(How = How.XPath, Using = ".//*[@id='no-bill-label']/span/span")]
        public IWebElement optDoNotHaveBill { get; set; }

        // What do you want to compare?
        // Gas & Electricity
        [FindsBy(How = How.XPath, Using = ".//*[@id='compare-both-label']/span/span")]
        public IWebElement optGasElectricity { get; set; }

        // Electricity only
        [FindsBy(How = How.XPath, Using = ".//*[@id='compare-electricity-label']/span/span")]
        public IWebElement optElectricityOnly { get; set; }

        // Gas only
        [FindsBy(How = How.XPath, Using = ".//*[@id='compare-gas-label']/span/span")]
        public IWebElement optGasOnly { get; set; }

        // Who supplies your electricity?
        // I don't know
        [FindsBy(How = How.XPath, Using = ".//*[@id='elec-energy-suppliers-question']/div/div/div[2]/label/span")]
        public IWebElement chkDontKnowElectricitySupplier { get; set; }

        // Who supplies your gas?
        // I don't know
        [FindsBy(How = How.XPath, Using = ".//*[@id='gas-energy-suppliers-question']/div/div/div[2]/label/span")]
        public IWebElement chkDontKnowGasSupplier { get; set; }
        
        // Next button
        [FindsBy(How = How.XPath, Using = ".//*[@id='goto-your-supplier-details']")]
        public IWebElement btnNext { get; set; }

        public YourEnergyNoBillPageObject SubmitSupplierDetails()
        {
            // Wait 5 Seconds
            System.Threading.Thread.Sleep(5000);

            // Click Next button
            SeleniumSetMethods.Click(btnNext);

            // Return the page object
            return new YourEnergyNoBillPageObject();
        }

        // EnergyToCompare takes one of three strings:
        // "GasElectricity" - Gas & Electricity
        // "ElectricityOnly" - Electricity only
        // "GasOnly" - Gas only
        // entering any other string will cause the default value (Gas & Electricity) to remain selected
        public void EnergyToCompare(string value)
        {
            if (value == "GasElectricity")
                optGasElectricity.Click();
            if (value == "ElectricityOnly")
                optElectricityOnly.Click();
            if (value == "GasOnly")
                optGasOnly.Click();
        }

        public void GasSupplierUnknown()
        {
            // Click on I don't know" Who supplies your gas? checkbox
            System.Threading.Thread.Sleep(5000);
            chkDontKnowGasSupplier.Click();
        }

        public void ElectricitySupplierUnknown()
        {
            // Click on I don't know" Who supplies your electricity? checkbox
            System.Threading.Thread.Sleep(5000);
            chkDontKnowElectricitySupplier.Click();
        }
    }
 }