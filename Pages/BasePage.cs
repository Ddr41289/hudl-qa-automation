using hudl_qa_automation.Utilities;

namespace hudl_qa_automation.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}