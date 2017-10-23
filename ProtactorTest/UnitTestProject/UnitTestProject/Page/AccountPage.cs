using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnitTestProject.Page
{
    class AccountPage: Page.BasePage
    {

        [FindsBy(How = How.XPath, Using = "//span[@class='fontBig ng-binding']")]
        public IWebElement accountName { set; get; }
        
        [FindsBy(How = How.XPath, Using = "//button[@ng-click='deposit()']")]
        public IWebElement depositButton { set; get; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement submitButton { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@ng-model='amount']")]
        public IWebElement amountField { set; get; }

        public string getAccountName()
        {
            return accountName.Text;
        }

        public void clickDepositButton()
        {
            depositButton.Click();
        }

        public ReadOnlyCollection<NgWebElement> accountInfo()
        {
            ReadOnlyCollection<NgWebElement> listDepositInfo = ng_driver.FindElements(By.XPath("//strong[@class='ng-binding']"));
            return listDepositInfo;
        }

        public void clickSubmitButton()
        {
            submitButton.Click();
        }

        public void enterDepositAmount(string amount)
        {
            amountField.SendKeys(amount);
        }

    }
}
