using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace hudl_qa_automation.Utilities
{
    public class Wait
    {
        private static readonly IWebDriver driver;
        private static readonly WebDriverWait wait;


        public static void Seconds(double seconds)
        {
            int milliseconds = (int)(seconds * 1000);
            Thread.Sleep(milliseconds);
        }

        public static void UntilElementIsVisible(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void UntilElementIsClickable(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void UntilElementTextContains(By locator, string text)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(locator, text));
        }

        public static void ForPageToLoad(IWebDriver driver, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }

}