using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProject.Hooks
{
    public class HomePage : BaseWebPage
    {
        By _homePageLabel = By.CssSelector("adp-sidebar-item[ng-reflect-icon='fa-home'] li span.vdl-sidebar-item__label");

        public string GetHomePageLabel()
        {
            return GetElementText(_homePageLabel);
        }
    }
}
