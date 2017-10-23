using OpenQA.Selenium.Chrome;
using Protractor;

namespace UnitTestProject.Factory
{
    class DriverFactory
    {
       static NgWebDriver ng_driver;
        public static NgWebDriver getNgDriver(string TypeOfDriver)
        {
            if (ng_driver != null)
            {
                return ng_driver;
            }
            else
            {
                return ng_driver = new NgWebDriver(new ChromeDriver());
            }
        }

    }
}
