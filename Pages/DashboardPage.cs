using Shouldly;
using hudl_qa_automation.Utilities;

namespace hudl_qa_automation.Pages
{
    public class DashboardPage : BasePage
    {
        private IWebDriver _driver;

        #region Variables
        #endregion

        #region Elements
        private readonly By userProfileDropdown = By.CssSelector("div.hui-globalusermenu > div.hui-globaluseritem");

        #endregion

        #region Constructors
        public DashboardPage(IWebDriver driver) : base(driver) 
        {
            _driver = driver;
            Wait.ForPageToLoad(_driver, 10);
            driver.SwitchTo().DefaultContent();
            driver.Title.ShouldContain("Home - Hudl");
        }

        #endregion

        #region Methods


        public DashboardPage VerifyUserIsLoggedIn()
        {
            _driver.FindElement(userProfileDropdown).Displayed.ShouldBeTrue();
            return this;
        }
        #endregion
    }

}