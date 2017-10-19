using Protractor;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace UnitTestProject.Page
{
    class CustomerPage

     {
        [FindsBy(How = How.XPath,Using = "//select[@id='userSelect']")]
        public IWebElement selectList { set; get; }


        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement loginButton { set; get; }

        public CustomerPage(NgWebDriver ng)
        {
            PageFactory.InitElements(ng, this);
        }

        public string getUrl(NgWebDriver ng)
        {
            return ng.Url;
        }

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
