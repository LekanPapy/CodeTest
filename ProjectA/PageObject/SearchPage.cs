using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProjectA.Utillities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.PageObject
{
    class SearchPage
    {
        public SearchPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[name=q]")]
        private IWebElement search { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement searching { get; set; }

        [FindsBy(How = How.Id, Using = "resultStats")]
        private IWebElement results { get; set; }

        private readonly string linkDisplayed = "Selenium - Web Browser Automation";

        public void EnterSearchCriteria(string value)
        {
            search.SendKeys(value);
        }

        public void SearchTheValue()
        {
            search.SendKeys(Keys.Enter);
        }

        public void VerifyRequiredLinkIsDisplayed ()
        {
            Assert.IsTrue(Hooks.Driver.PageSource.Contains(linkDisplayed));
        }
        
        public void VerifyResultsIsDisplay ()
        {
            var returnedResult = results.Text;
            Assert.IsTrue(returnedResult.Contains("About") && returnedResult.Contains("results"));
        }

    }


   
}
