using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheMarketEnergy
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static void GetTableData()
        {
            IList<IWebElement> allElement = PropertiesCollection.driver.FindElements(By.TagName("td"));
            foreach (IWebElement element in allElement)
            {
                string cellText = element.Text;
                Console.WriteLine(cellText);
            }
        }
    }
}