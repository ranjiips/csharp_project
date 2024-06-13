using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExploreCSharp.SeleniumWeb
{
    public class SeleniumMulitpleWindows:SeleniumBaseWebInteractions
    {
        By openNewWidnowLocator = By.CssSelector("div.example a");
        public void OpenChildWindow(string title)
        {
            ClickElement(openNewWidnowLocator);
            SwitchToWindows(title);
        }
    }
}
