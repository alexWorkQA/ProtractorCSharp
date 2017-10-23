using System.Collections;
using System.Linq;
using Protractor;
using System.Collections.ObjectModel;

namespace UnitTestProject.Helpers
{
    class CustomerPageHelper : Page.CustomerPage
    {
        public CustomerPageHelper() : base()
        {
            
        }

        public string getUrlForAssert()
        {
            return ng_driver.Url;
        }

        public void selectAlbusCustomer()
        {
            openCustomerList();
            ReadOnlyCollection<NgWebElement> customers = getCustomerList();
            var customer = customers.ElementAt(3);
            customer.Click();
            clickLoginButton();
        }


    }
}
