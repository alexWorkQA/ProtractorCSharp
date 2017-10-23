using Protractor;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

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

        public ReadOnlyCollection<NgWebElement> getCustomerList()
        {
            return ng_driver.FindElements(NgBy.Repeater("cust in Customers"));
        }
    }
}
