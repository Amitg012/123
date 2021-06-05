using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzL.Core;

namespace TzL.Repository
{
    public class DemoChart: BasePage
    {
        readonly IWebDriver _driver = null;
        #region Constructor

        public DemoChart(IWebDriver driver)
        {
            _driver = driver;
        }
        #endregion

        #region Object Repository

        private IWebElement SearchTestItems => _driver.css("input[placeholder='Search items...']");

        private IList<IWebElement> HotDealsLink => _driver.Allcss(".primary-title");

        private IWebElement Sale => _driver.LinkText("Sale");

        private IWebElement Iphone => _driver.LinkText("Search powered by CloudSearch");

        private IWebElement Android => _driver.LinkText("Search powered by CloudSearch");

        #endregion

        #region TestCase Methods

        public void SearchItems(string value1, string value2)
        {
            LogMessage("Entering a vlaue into Search Items Text Box", () => Input(SearchTestItems, value1));

            LogMessage("Validating if Iphones are Visible", () => AssertIsTrue(Iphone.Displayed));

            LogMessage("Entering a vlaue into Search Items Text Box", () => ClearAndInput(SearchTestItems, value2));

            LogMessage("Validating if Android are Visible", () => AssertIsTrue(Android.Displayed));
        }

        public void HotDeals()
        {
            LogMessage("Mosue Hover on Hot Deals Text", () => MouseHover(HotDealsLink[1], _driver));
            LogMessage("Click on Sale text",() => Click(Sale));
        }

        #endregion

    }
}
