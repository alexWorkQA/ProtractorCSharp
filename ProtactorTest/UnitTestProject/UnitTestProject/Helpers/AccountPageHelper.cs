using Protractor;
using System;
using System.Collections.ObjectModel;
using System.Linq;


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
            ReadOnlyCollection<NgWebElement> listDepoInfo = accountInfo();
            string balance = listDepoInfo.ElementAt(1).Text;
            return Int32.Parse(balance);
        }

        public void addToDeposit(string amount)
        {
            clickDepositButton();
            enterDepositAmount(amount);
            clickSubmitButton();
        }

    }
}
