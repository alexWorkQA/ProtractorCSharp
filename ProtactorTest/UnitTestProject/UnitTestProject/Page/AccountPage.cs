using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject.Page
{
    class AccountPage: Page.BasePage
    {

        [FindsBy(How = How.XPath, Using = "//span[@class='fontBig ng-binding']")]
        public IWebElement accountName { set; get; }

        public string getAccountName()
        {
            return accountName.Text;
        }

    }
}
