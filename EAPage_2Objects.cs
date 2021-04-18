using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSwagLabs
{
    class EAPage_2Objects
    {
        public EAPage_2Objects()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
    }
}
