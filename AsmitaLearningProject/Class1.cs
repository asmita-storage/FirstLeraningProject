using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsmitaLearningProject
{
    public class CommonMethods : WebDriverClass
    {

        public void TextBox(IWebElement webElement,String TextToEnter)
        {
            webElement.SendKeys(TextToEnter);
        }

        public void ButtonClick(IWebElement webElement)
        {
            webElement.Click();
        }
        public void ComboBox(string TextToInput,String ControlToPass)
        { 
         IWebElement ComboBox= Driver.FindElement(By.XPath($"//input[@id='{ControlToPass}']"));
            ComboBox.Clear();
            ComboBox.SendKeys($"{TextToInput}");
        }



    }
}
