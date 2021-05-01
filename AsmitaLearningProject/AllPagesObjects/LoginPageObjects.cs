using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AsmitaLearningProject
{
    public class LoginPageObjects : WebDriverClass
    {
      
        public IWebElement LoginButtonTest => Driver.FindElement(By.Id("loginLink"));
        public IWebElement UserNameTextBox => Driver.FindElement(By.Id("UserName"));
        public IWebElement PasswordTextBox => Driver.FindElement(By.Id("Password"));
        public IWebElement GetInButtonTextBox => Driver.FindElement(By.XPath("//*[@class='btn btn-default']"));
       
    }
}
