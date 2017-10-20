using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using UnitTestProject.Factory;

namespace UnitTestProject.Page
{
    class BasePage
    {
      public static NgWebDriver ng_driver = DriverFactory.getNgDriver("chrome");

      public BasePage()
        {
            PageFactory.InitElements(ng_driver, this);
        }
      
    }

}




