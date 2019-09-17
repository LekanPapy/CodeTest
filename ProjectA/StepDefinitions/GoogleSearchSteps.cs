using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using ProjectA.PageObject;
using ProjectA.Utillities;
using System;
using TechTalk.SpecFlow;

namespace ProjectA.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps
    {
        SearchPage mySearch;

        public GoogleSearchSteps()
        {
            mySearch = new SearchPage();
        }
        [Given(@"user is on Google homepage")]
        public void GivenUserIsOnGoogleHomepage()
        {
            
            Hooks.Driver.Navigate().GoToUrl("http://google.com");
            Hooks.Driver.Manage().Window.Maximize();
                
        }
        
        [When(@"user searches for ""(.*)""")]
        public void WhenUserSearchesFor(string value)
        {
            mySearch.EnterSearchCriteria(value);
            mySearch.SearchTheValue();
            
        }
        
        [Then(@"correct results are returned")]
        public void ThenCorrectResultsAreReturned()
        {
            mySearch.VerifyRequiredLinkIsDisplayed();

            mySearch.VerifyResultsIsDisplay();
        }
    }
}
