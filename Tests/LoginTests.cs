using OpenQA.Selenium.Chrome;
using hudl_qa_automation.Pages;
using hudl_qa_automation.Utilities;
using WebDriverManager.DriverConfigs.Impl;


namespace hudl_qa_automation.Tests
{
    [TestFixture]
    public class LoginTests
    {
        public IWebDriver _driver;
        public string url = "https://www.hudl.com/";
        HomePage homePage;
        LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
            homePage = new HomePage(_driver);
            homePage
                .Click(homePage.loginButton)
                .Click(homePage.Hudl);
        }

        [Test]
        [Category("Login Tests")]
        [Description("Verify user can login with valid credentials")]
        public void LoginWithValidCredentials()
        {
            loginPage = new LoginPage(_driver);
            loginPage
                .Login("\\hudl-qa-automation\\Config\\loginCredentials.json");
            DashboardPage dashboardPage = new(_driver);
            dashboardPage
                .VerifyUserIsLoggedIn();
        }


        [Test]
        [Category("Login Tests")]
        [Description("Verify user cannot login with invalid credentials")]
        public void LoginWithInvalidCredentials()
        {
            loginPage = new(_driver);
            loginPage
                 .InvalidLogin("random_", "willFail");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Quit();
        }
    }
}