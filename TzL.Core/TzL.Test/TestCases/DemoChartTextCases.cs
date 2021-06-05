using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzL.Core;
using TzL.Repository;

namespace TzL.Test.TestCases
{
    class DemoChartTextCases : BaseTest
    {
        [Test]

        public void VerifiyItemsSearchedInSearchItemsTextBox()
        {
            try
            {
                LogMessage("Navigate To Url", () => NavigateToUrl("https://demostore.x-cart.com/", Driver));

                var pgDemoChart = Page<DemoChart>(Driver);

                LogMessage("Invoking Search Items Method", () => pgDemoChart.SearchItems("Iphone", "Android"));

                LogMessage("Close Browser", () => CloseBrowser(Driver));

            }

            catch(Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }
        }


    }
}
