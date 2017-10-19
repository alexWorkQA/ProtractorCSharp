using NUnit.Framework;
using Protractor;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Page;
using System;
using System.Threading;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
   {
        private static IWebDriver driver;
        private static NgWebDriver ngDr;
        private MainPage mainPage;
        private CustomerPage customerPage;

        [SetUp]
        public void SetupWebDriver()

        {
            driver = new ChromeDriver();
            ngDr = new NgWebDriver(driver);
            driver.Navigate().GoToUrl("http://www.way2automation.com/angularjs-protractor/banking/#/login");
            mainPage = new MainPage(ngDr);
            customerPage = new CustomerPage(ngDr);
        }

        [Test]
        public void TestMethod()
        {
            mainPage.clickCustomersButton();
            string assertUrl = customerPage.getUrl(ngDr);
            NUnit.Framework.Assert.AreEqual("http://www.way2automation.com/angularjs-protractor/banking/#/customer", assertUrl);
            customerPage.openCustomerList();
            ReadOnlyCollection <NgWebElement> customers = ngDr.FindElements(NgBy.Repeater("cust in Customers"));
            var fisrtCustomer = customers.ElementAt(3);
            fisrtCustomer.Click();
            //customer.Where(customers => Regex.IsMatch(customers.Text, "Harry Potter"));
            customerPage.clickLoginButton();
            Thread.Sleep(2000);
        }


        [TearDown]
        public void CloseWebDriver()
        {
            driver.Close();
        }
    }
}
