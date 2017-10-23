using OpenQA.Selenium.Chrome;
using Protractor;

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
