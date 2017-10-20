using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Helpers
{
    class AccountPageHelper:Page.AccountPage
    {
        public string getAccountNameForAssert()
        {
            return getAccountName();
        }

        public int getAccountBalance()
        {
            IReadOnlyCollection<IWebElement> listDepoInfo = accountInfo();
            string balance = listDepoInfo.ElementAt(1).Text;
            int i = Int32.Parse(balance);
            return i;
        }

        public void addToDeposit(string amount)
        {
            clickDepositButton();
            enterDepositAmount(amount);
            clickSubmitButton();
        }

    }
}
