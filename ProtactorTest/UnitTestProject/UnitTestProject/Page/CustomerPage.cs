using Protractor;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace UnitTestProject.Page
{
    class CustomerPage : BasePage

     {
        [FindsBy(How = How.XPath,Using = "//select[@id='userSelect']")]
        public IWebElement selectList { set; get; }


        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement loginButton { set; get; }

        public void openCustomerList()
        {
            selectList.Click();
        }

        public void clickLoginButton()
        {
            loginButton.Click();
        }
    }
}
