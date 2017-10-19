using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;

namespace UnitTestProject.Helpers
{
    class CustomerPageHelper : Page.CustomerPage
    {
        public CustomerPageHelper(NgWebDriver ng) : base(ng)
        {
        }
    }
}
