using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Given(@"The sellers' is in the Certification page")]
        public void GivenTheSellersIsInTheCertificationPage()
        {
            NewCertificate.Certificatebtn.Click();
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The sellers' click AddNew Button And Enter details on cert page")]
        public void WhenTheSellersClickAddNewButtonAndEnterDetailsOnCertPage()
        {
            NewCertificate.AddStep();
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"The sellers' click Update button and Edit details on cert page")]
        public void WhenTheSellersClickUpdateButtonAndEditDetailsOnCertPage()
        {
            NewCertificate.UpdateStep();
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The sellers' click the Delete button on cert page")]
        public void WhenTheSellersClickTheDeleteButtonOnCertPage()
        {
            NewCertificate.DeleteStep();
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"The sellers' is click  AddNew button and Enter same details on cert page")]
        public void WhenTheSellersIsClickAddNewButtonAndEnterSameDetailsOnCertPage()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"The sellers' click AddNew button and keep blank details on cert page")]
        public void WhenTheSellersClickAddNewButtonAndKeepBlankDetailsOnCertPage()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"The sellers' able to view  Certificate Successfully Added")]
        public void ThenTheSellersAbleToViewCertificateSuccessfullyAdded()
        {
           // NewCertificate.AddDataValidate();
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"The sellers' able to see Certificate Updated Successfully")]
        public void ThenTheSellersAbleToSeeCertificateUpdatedSuccessfully()
        {
            NewCertificate.ValidateUpdateData();
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should be Certificate Deleted Successfully")]
        public void ThenTheMessageShouldBeCertificateDeletedSuccessfully()
        {
           // NewCertificate.ValidateDeletedData();

            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should appear  Duplicate data")]
        public void ThenTheMessageShouldAppearDuplicateData()
        {

            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should display Please enter Certificates")]
        public void ThenTheMessageShouldDisplayPleaseEnterCertificates()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
