using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Helpers
{
    class CommonHelper:Page.BasePage
    {
       public void openWebBrowser()
        {
            ng_driver.Navigate().GoToUrl("http://www.way2automation.com/angularjs-protractor/banking/#/login");
        } 


        public void closeWebBrowser()
        {
            ng_driver.Close();
        }
    }
}
