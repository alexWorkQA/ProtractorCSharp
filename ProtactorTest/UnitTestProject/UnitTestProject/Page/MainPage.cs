﻿using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using OpenQA.Selenium;

namespace UnitTestProject.Page
{
    class MainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//button[@ng-click='customer()']")]
        public IWebElement button { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@ng-model='custId']")]
        public IWebElement dropDown { get; set; }


        public void clickCustomersButton()
        {
            button.Click();
        }

        public void clickDropDown()
        {
            dropDown.Click();
        }
    }
}
