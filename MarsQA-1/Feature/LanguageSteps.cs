using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LanguageSteps
    {
        [Given(@"Seller is on profile page to add a new language")]
        public void GivenSellerIsOnProfilePageToAddANewLanguage()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller is on profile page language tab and clicks on edit button for english")]
        public void GivenSellerIsOnProfilePageLanguageTabAndClicksOnEditButtonForEnglish()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller is on profile page to language tab and clicks  on delete button for Mandarin")]
        public void GivenSellerIsOnProfilePageToLanguageTabAndClicksOnDeleteButtonForMandarin()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller enters  new language")]
        public void WhenTheSellerEntersNewLanguage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"Selects the language level")]
        public void WhenSelectsTheLanguageLevel(Table table)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller enters  English language")]
        public void WhenTheSellerEntersEnglishLanguage()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"Selects the language level as Fluent")]
        public void WhenSelectsTheLanguageLevelAsFluent(Table table)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller enters  null  language")]
        public void WhenTheSellerEntersNullLanguage()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"Selects the language level as Null")]
        public void WhenSelectsTheLanguageLevelAsNull(Table table)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller enters  French language")]
        public void WhenTheSellerEntersFrenchLanguage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller updates language")]
        public void WhenTheSellerUpdatesLanguage(Table table)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller deletes Mandarin language")]
        public void WhenTheSellerDeletesMandarinLanguage()
        {
          //  ScenarioContext.Current.Pending();
        }
    }
}
