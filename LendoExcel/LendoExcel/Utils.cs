using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendoExcel
{
    class Utils
    {
        public static IWebElement WaitUntilElementExists(IWebDriver driver, By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                return null;
            }
        }
    }
}
