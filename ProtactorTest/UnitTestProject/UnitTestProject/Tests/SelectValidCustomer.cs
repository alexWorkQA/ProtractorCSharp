﻿using NUnit.Framework;
using UnitTestProject.Factory;

namespace UnitTestProject
{
    [TestFixture]
    class UnitTest
   {
        ApplicationFactory app;

        [SetUp]
        public void SetupWebDriver()
        {
            app = new ApplicationFactory();
            app.commonHelper.openWebBrowser();
        }

        [Test]
        public void AlbusWasAbleToOpenAccountPage()
        {
            app.mainPageHelper.openCustomerPage();
            app.customerPageHelper.selectAlbusCustomer();
            Assert.AreEqual("Albus Dumbledore", app.accountHelper.getAccountNameForAssert());
        }

        [TearDown]
        public void CloseWebDriver()
        {
            app.commonHelper.closeWebBrowser();
        }
    }
}
