using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using UnitTestProject.Helpers;
using UnitTestProject.Tests;

namespace UnitTestProject
{
    [TestClass]
    class UnitTest
   {
       CommonHelper commonHelper = new CommonHelper();
       MainPageHelper mainPageHelper = new MainPageHelper();
       CustomerPageHelper customerPageHelper = new CustomerPageHelper();
        AccountPageHelper accountHelper = new AccountPageHelper();

        [SetUp]
        public void SetupWebDriver()
        {
            commonHelper.openWebBrowser();
        }

        [Test]
        public void AlbusWasAbleToOpenAccountPage()
        {
            mainPageHelper.openCustomerPage();
            string assertUrl = customerPageHelper.getUrlForAssert();
            NUnit.Framework.Assert.AreEqual("http://www.way2automation.com/angularjs-protractor/banking/#/customer", assertUrl);
            customerPageHelper.selectAlbusCustomer();
            string assertAccountName = accountHelper.getAccountNameForAssert();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Albus Dumbledore", assertAccountName);
            Thread.Sleep(2000);
        }


        [TearDown]
        public void CloseWebDriver()
        {
            commonHelper.closeWebBrowser();
        }
    }
}
