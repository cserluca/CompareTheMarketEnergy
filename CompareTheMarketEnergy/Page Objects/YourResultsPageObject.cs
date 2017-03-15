using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheMarketEnergy
{
    class YourResultsPageObject
    {
        // YourResultsPageObject Constructor
        public YourResultsPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
    }
}