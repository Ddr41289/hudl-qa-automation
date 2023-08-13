using Shouldly;
using System.Text.Json;
using hudl_qa_automation.Utilities;
using Newtonsoft.Json.Linq;

namespace hudl_qa_automation.Pages
{
    public class LoginPage : BasePage
    {
        public IWebDriver _driver;

        #region Variables
        #endregion

        #region Elements
        public readonly By emailInput = By.Id("email");
        public readonly By passwordInput = By.Id("password");
        public readonly By forgotPasswordLink = By.Id("forgot-password");
        public readonly By continueButton = By.Id("logIn");
        public readonly By createAccountButton = By.Id("btn-show-signup");
        #endregion

        #region Constructors
        public LoginPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            Wait.Seconds(5);
            //Could not use wait for PageToLoad due to transition screen
            driver.SwitchTo().DefaultContent();
            //Could not Assert driver.Title shouldBe "Log In", because theres a screen that displays in transition that has the title: "One platform to help the whole team improve | Hudl"
        }


        #endregion

        #region Methods

        public LoginPage Click(By by)
        {
            Wait.UntilElementIsClickable(by);
            _driver.FindElement(by).Click();
            return this;
        }

        public LoginPage Login(string filePath)
        {
            string jsonFilePath = "C:\\Users\\docda\\source\\repos\\hudl-qa-automation\\Config\\loginCredentials.json";
            (string username, string password) = ReadCredentialsFromJson(jsonFilePath);
            _driver.FindElement(emailInput).SendKeys(username);
            _driver.FindElement(passwordInput).SendKeys(password);
            Click(continueButton);
            return this;
        }

        public LoginPage InvalidLogin(string username, string password)
        {
            _driver.FindElement(emailInput).SendKeys(username);
            _driver.FindElement(passwordInput).SendKeys(password);
            Click(continueButton);
            return this;
        }

        static (string, string) ReadCredentialsFromJson(string filePath)
        {
            string jsonData = System.IO.File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonData);
            string username = jsonObject["username"].ToString();
            string password = jsonObject["password"].ToString();
            return (username, password);
        }


        #endregion

    }

}