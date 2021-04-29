using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsmitaLearningProject
{
    class CommonMethods : WebDriverClass
    {
        public void ComboBox(string TextToInput,String ControlToPass)
        { 
         IWebElement ComboBox= Driver.FindElement(By.XPath($"//input[@id='{ControlToPass}']"));
            ComboBox.Clear();
            ComboBox.SendKeys($"{TextToInput}");
        }

    }
}
