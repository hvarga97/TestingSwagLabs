using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSwagLabs
{
    class EAPage_1Objects
    {
        public EAPage_1Objects()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "add-to-cart-sauce-labs-backpack")]
        public IWebElement btnItemSauceLabsBackpack { get; set; }
        [FindsBy(How = How.Name, Using = "remove-sauce-labs-backpack")]
        public IWebElement btnItemRemoveSauceLabsBackpack { get; set; }
        [FindsBy(How = How.Name, Using = "add-to-cart-sauce-labs-bike-light")]
        public IWebElement btnItemSauceLabsBikeLight { get; set; }
        [FindsBy(How = How.Name, Using = "remove-sauce-labs-bike-light")]
        public IWebElement btnItemRemoveSauceLabsBikeLight { get; set; }
        [FindsBy(How = How.Name, Using = "add-to-cart-sauce-labs-bolt-t-shirt")]
        public IWebElement btnItemSauceLabsBoltT_Shirt { get; set; }
        [FindsBy(How = How.Name, Using = "remove-sauce-labs-bolt-t-shirt")]
        public IWebElement btnItemRemoveSauceLabsBoltT_Shirt { get; set; }
        [FindsBy(How = How.Name, Using = "add-to-cart-sauce-labs-fleece-jacket")]
        public IWebElement btnItemSauceLabsFleeceJacket { get; set; }
        [FindsBy(How = How.Name, Using = "remove-sauce-labs-fleece-jacket")]
        public IWebElement btnItemRemoveSauceLabsFleeceJacket { get; set; }
        [FindsBy(How = How.Name, Using = "add-to-cart-sauce-labs-onesie")]
        public IWebElement btnItemSauceLabsOnesie { get; set; }
        [FindsBy(How = How.Name, Using = "remove-sauce-labs-onesie")]
        public IWebElement btnItemRemoveSauceLabsOnesie { get; set; }
        [FindsBy(How = How.Name, Using = "add-to-cart-test.allthethings()-t-shirt-(red)")]
        public IWebElement btnItemTestallTheThingsT_ShirtRed { get; set; }
        [FindsBy(How = How.Name, Using = "remove-test.allthethings()-t-shirt-(red)")]
        public IWebElement btnItemRemoveTestallTheThingsT_ShirtRed { get; set; }
        [FindsBy(How = How.Id, Using = "shopping_cart_container")]
        public IWebElement btnCart { get; set; }


        public void DoTheShopping()
        {
            btnItemSauceLabsBackpack.Click();
            btnItemSauceLabsBikeLight.Click();
            btnItemSauceLabsBoltT_Shirt.Click();
            btnItemSauceLabsFleeceJacket.Click();
            btnItemSauceLabsOnesie.Click();
            btnItemTestallTheThingsT_ShirtRed.Click();
        }

        public void RemoveItemsFromCart()
        {
            btnItemRemoveSauceLabsBackpack.Click();
            btnItemRemoveSauceLabsBikeLight.Click();
            btnItemRemoveSauceLabsBoltT_Shirt.Click();
            btnItemRemoveSauceLabsFleeceJacket.Click();
            btnItemRemoveSauceLabsOnesie.Click();
            btnItemRemoveTestallTheThingsT_ShirtRed.Click();
        }

        public EAPage_2Objects OpenCart()
        {
            btnCart.Click();
            return new EAPage_2Objects();
        }

    }
}
