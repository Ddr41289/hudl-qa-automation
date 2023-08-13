using hudl_qa_automation.Utilities;
using Shouldly;

namespace hudl_qa_automation.Pages
{

    public class HomePage : BasePage
    {
        private readonly IWebDriver _driver;


        #region Elements
        public readonly By loginButton = By.CssSelector("a[data-qa-id='login-select']");
        public readonly By Hudl = By.LinkText("Hudl");
        #endregion

        #region Constructors
        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            Wait.ForPageToLoad(_driver, 10);
            driver.SwitchTo().DefaultContent();
            driver.Title.ShouldContain("Hudl • Tools to help every team, coach and athlete improve");
        }
        #endregion

        #region Methods

        public HomePage Click(By by)
        {
            _driver.FindElement(by).Click();
            return this;
        }
        #endregion
    }

}