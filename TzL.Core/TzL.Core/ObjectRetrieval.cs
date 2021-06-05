using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
namespace TzL.Core
{
    [Obsolete]
   public static class ObjectRetrieval
    {

        public static IWebElement GetElement(this IWebDriver driver, By by, int waittime = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waittime));

            return wait.Until(ExpectedConditions.ElementExists(by));
        }

        public static IList<IWebElement> GetElements(this IWebDriver driver, By by, int waittime = 15)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waittime));

            return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

        public static IWebElement css(this IWebDriver driver, string CssSelector)
        {
            return driver.GetElement(By.CssSelector(CssSelector));
        }

        public static IList<IWebElement> Allcss(this IWebDriver driver, string cssSelector)
        {
            return driver.GetElements(By.CssSelector(cssSelector));
        }
        public static IWebElement LinkText(this IWebDriver driver, string text)
        {
            return driver.GetElement(By.LinkText(text));
        }
    }
}

