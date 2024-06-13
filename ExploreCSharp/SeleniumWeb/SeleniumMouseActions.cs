using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExploreCSharp.SeleniumWeb
{
    public class SeleniumMouseActions:SeleniumBaseWebInteractions
    {
        By dragFromLocator = By.CssSelector("div#column-a");
        By dragToLocator = By.CssSelector("div#column-b");

        public void DragAndDropAction()
        {
            IWebElement dragFromElement = Driver.FindElement(dragFromLocator);
            IWebElement dragToElement = Driver.FindElement(dragToLocator);

            string fromvalue_beforedrag = dragFromElement.Text;
            string tovalue_beforedrag = dragToElement.Text;
            Console.WriteLine($"Before Drag and drop, From text: {fromvalue_beforedrag}; To text: {tovalue_beforedrag}");
            DragAndDrop(dragFromElement, dragToElement);
            string fromvalue_afterdrag = dragFromElement.Text;
            string tovalue_afterdrag = dragToElement.Text;
            Console.WriteLine($"After Drag and drop, From text: {fromvalue_afterdrag}; To text: {tovalue_afterdrag}");
        }
    }
}
