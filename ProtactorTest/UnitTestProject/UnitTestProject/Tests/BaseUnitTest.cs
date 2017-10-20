using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestProject.Helpers;

namespace UnitTestProject.Tests
{
    [TestClass]
    public class BaseUnitTest
    {
        CommonHelper commonHelper;

        [SetUp]
        public void SetupHelpers()
        {
          commonHelper = new CommonHelper();
        }
      
        MainPageHelper mainPageHelper = new MainPageHelper();
        CustomerPageHelper customerPageHelper = new CustomerPageHelper();
    }
}


