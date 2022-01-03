using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        [Given(@"The sellers' is in the Education page")]
        public void GivenTheSellersIsInTheEducationPage()
        {
          
           // Driver.TurnOnWait();
        }
        
        [When(@"The sellers' click AddNew Button And Enter details")]
        public void WhenTheSellersClickAddNewButtonAndEnterDetails()
        {
            //ScenarioContext.Current.Pending();
            Driver.TurnOnWait();
        }
        
        [When(@"The sellers' click Update button and Edit details")]
        public void WhenTheSellersClickUpdateButtonAndEditDetails()
        {
           
            // ScenarioContext.Current.Pending();
            Driver.TurnOnWait();
        }
        
        [When(@"The sellers' click the Delete button")]
        public void WhenTheSellersClickTheDeleteButton()
        {
          
            // ScenarioContext.Current.Pending();
        }
        
        [When(@"The sellers' is click  AddNew button and Enter same details")]
        public void WhenTheSellersIsClickAddNewButtonAndEnterSameDetails()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"The sellers' click AddNew button and keep blank details")]
        public void WhenTheSellersClickAddNewButtonAndKeepBlankDetails()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The sellers' able to view  Education has been Added")]
        public void ThenTheSellersAbleToViewEducationHasBeenAdded()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The sellers' able to see Education has been  Updated")]
        public void ThenTheSellersAbleToSeeEducationHasBeenUpdated()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should be Education has been Deleted")]
        public void ThenTheMessageShouldBeEducationHasBeenDeleted()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should appear  The inforfamtion is already exists")]
        public void ThenTheMessageShouldAppearTheInforfamtionIsAlreadyExists()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should display Please enter all fields")]
        public void ThenTheMessageShouldDisplayPleaseEnterAllFields()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
