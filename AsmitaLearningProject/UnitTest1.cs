using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AsmitaLearningProject
{
    public class Tests : WebDriverClass
    {
    
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            /*Driver.Url = "https://demowf.aspnetawesome.com/";*/
            Driver.Url = "http://eaapp.somee.com/Account/Login";
        }

        [Test]
        public void Test1()
        {

            /*Driver.FindElement(By.XPath("//button[text()='OK']")).Click();*/
            /*Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");*/
            /* Thread.Sleep(1000);*/
            /*Driver.FindElement(By.XPath("//li[@class='o-itm o-v o-ditm focus']")).Click();*/
            /*Thread.Sleep(1000);*/
            //Driver.FindElement(By.XPath("//div[text()='Celery']//ancestor::label//*[@class='o-chkico']")).Click();

            /*Driver.FindElement(By.XPath("(//label[@class='awe-label'])[6]//div[@tabindex='0']//div//div")).Click();*/
            /*commonMethods.ComboBox("Almonds", "ContentPlaceHolder1_AllMealsCombo-awed");*/

            CommonMethods commonMethods = new CommonMethods();
            LoginPageObjects pageObjects = new LoginPageObjects();

            commonMethods.TextBox(pageObjects.UserNameTextBox,"barsia");
            Thread.Sleep(1000);
            commonMethods.TextBox(pageObjects.PasswordTextBox,"Vickey@1995");
            Thread.Sleep(1000);
            commonMethods.ButtonClick(pageObjects.GetInButtonTextBox);
            Assert.Pass();

            
          
        }

      
    }
}