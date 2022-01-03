using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Education
    {
        //add
        public static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        public static IWebElement AddNewEdu => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        
        public static IWebElement University => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        public static IWebElement Country => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));

        public static IWebElement CountryOpt => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[11]"));
        public static IWebElement Title => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));

        public static IWebElement TitlteOPt => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
        public static IWebElement Degree => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        public static IWebElement GradYear => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        public static IWebElement GradYearOpt => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[13]"));
        public static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
       
        public static IWebElement AddCancelbtn => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[2]"));


       


        //Update
        public static IWebElement UpdateIcon => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i"));
        public static IWebElement UpdateUniversity => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[1]/input"));
        public static IWebElement UpdateCountry => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[2]/select"));

        public static IWebElement UpdateCountryOpt => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[2]/select/option[15]"));
        public static IWebElement UpdateTitle => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[1]/select"));

        public static IWebElement UpdateTitlteOPt => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[1]/select/option[4]"));
        public static IWebElement UpdateDegree => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[2]/input"));
        public static IWebElement UpdateGradYear => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[3]/select"));
        public static IWebElement UpdateGradYearOpt => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[3]/select/option[10]"));
        public static IWebElement UpdateButton => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]"));

        //public static IWebElement findRecordCreated => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //Delete
        public static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i"));
       //
       //\private static IWebElement findEditedRecord => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr[last()]/td[1]"));


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        public static void AddNewEduStep()
        {
            //Driver.NavigateUrl();
            //EducationTab.Click();

            //Thread.Sleep(2000);
            //Task.Delay(2000);
            AddNewEdu.Click();
            Driver.TurnOnWait();

            // Task.Delay(2000);
            University.SendKeys("ACC");
            Driver.TurnOnWait();
            Country.Click();
            CountryOpt.Click();
            Title.Click();
            TitlteOPt.Click();
            Degree.SendKeys("Electronics");
            Driver.TurnOnWait();
            // Task.Delay(2000);
            GradYear.Click();
           // Task.Delay(2000);
            GradYearOpt.Click();
          //  Task.Delay(2000);
            AddButton.Click();
        }
        public static void UpdateEduStep()
        {
            UpdateIcon.Click();

            UpdateUniversity.SendKeys("AVC");
            Driver.TurnOnWait();
            UpdateCountry.Click();
            UpdateCountryOpt.Click();
            UpdateTitle.Click();
            Driver.TurnOnWait();
            UpdateTitlteOPt.Click();

            UpdateButton.Click();


          

        }
        public static void DeleteEdustep()
        {
            DeleteBtn.Click();
            Console.WriteLine("Deleted");
        }
    }
}
