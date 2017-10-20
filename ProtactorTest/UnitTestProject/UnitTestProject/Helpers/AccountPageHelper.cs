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

    }
}
