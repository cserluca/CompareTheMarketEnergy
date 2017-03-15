using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheMarketEnergy
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
        XPath
    }
    class PropertiesCollection
    {
        //Auto implemented property
        public static IWebDriver driver { get; set; }
    }
}
