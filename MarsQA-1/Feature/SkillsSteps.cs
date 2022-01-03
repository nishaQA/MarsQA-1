using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"Seller is on profile page to add a new skill")]
        public void GivenSellerIsOnProfilePageToAddANewSkill()
        {
          //  ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller is on profile page Skills tab and clicks on edit button for Baking")]
        public void GivenSellerIsOnProfilePageSkillsTabAndClicksOnEditButtonForBaking()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller is on profile page to Skills tab and clicks  on delete button for Cookies")]
        public void GivenSellerIsOnProfilePageToSkillsTabAndClicksOnDeleteButtonForCookies()
        {
          //  ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller enters  new skill")]
        public void WhenTheSellerEntersNewSkill()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"Selects the skill level")]
        public void WhenSelectsTheSkillLevel(Table table)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller updates skills")]
        public void WhenTheSellerUpdatesSkills(Table table)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The seller deletes Cookies Skill")]
        public void WhenTheSellerDeletesCookiesSkill()
        {
          //  ScenarioContext.Current.Pending();
        }
        
        [Then(@"A message should be displayed ""(.*)""")]
        public void ThenAMessageShouldBeDisplayed(string p0)
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
