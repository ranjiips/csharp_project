using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExploreCSharp.SeleniumWeb
{
    public class SeleniumFormActions:SeleniumBaseWebInteractions
    {
        public By checkboxPageHeaderLocator = By.CssSelector("div#content h3");

        By checkBoxLocator = By.XPath("//input[@type='checkbox']"); 

        public void SelectCheckBox(By locator)
        {
            var element = Driver.FindElements(locator);
            foreach (var item in element)
            {
                bool status = IsCheckBoxSelected(item);
                Console.WriteLine($"Check box status (before click): {status}");
                item.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }

        public void UnselectAndSelectCheckbox()
        {
            SelectCheckBox(checkBoxLocator);
        }
    }
}
