using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSwagLabs
{
    enum PropertyType
    {
        Id,
        Name,
        Value
    }

    class PropertyCollection
    {
        public static IWebDriver driver{ get; set;}
    }
}
