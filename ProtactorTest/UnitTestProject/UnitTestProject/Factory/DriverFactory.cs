using OpenQA.Selenium.Chrome;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Factory
{
    class DriverFactory
    {
        public static NgWebDriver getNgDriver(string TypeOfDriver)
        {
            NgWebDriver ng_driver = new NgWebDriver(new ChromeDriver());
            return ng_driver;
        }

    }
}
