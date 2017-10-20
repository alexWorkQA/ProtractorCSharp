using NUnit.Framework;
using System.Threading;
using UnitTestProject.Factory;

namespace UnitTestProject.Tests
{
    [TestFixture]
    class UserAddNewDeposit
    {
        ApplicationFactory app;

        [SetUp]
        public void SetupWebDriver()
        {
            app = new ApplicationFactory();
            app.commonHelper.openWebBrowser();
        }

        [Test]
        public void AlbusWasAbleToAddNewDeposit()
        {
            app.mainPageHelper.openCustomerPage();
            app.customerPageHelper.selectAlbusCustomer();
            Assert.AreEqual(0, app.accountHelper.getAccountBalance());
            app.accountHelper.addToDeposit("50");
            Assert.AreEqual(50, app.accountHelper.getAccountBalance());
        }

        [TearDown]
        public void CloseWebDriver()
        {
            app.commonHelper.closeWebBrowser();
        }

    }
}
