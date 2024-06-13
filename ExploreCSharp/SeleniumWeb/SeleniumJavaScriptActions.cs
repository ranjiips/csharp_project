using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExploreCSharp.SeleniumWeb
{
    public class SeleniumJavaScriptActions:SeleniumBaseWebInteractions
    {
        By AuthenticanMessageLocator = By.CssSelector("div.example"); 
        

        public void EnterCredentialsInJSPopup()
        {
            var alert = SwitchToAlert();
            GetPopupContent(alert);
            EnterTextInJavaScriptInput(alert, "admin");
            EnterTextInJavaScriptInput(alert, "admin");
            AcceptJavaScriptAlert(alert);
        }

        public void VerifyJavaScriptLoginMessage()
        {
            string content = GetText(AuthenticanMessageLocator);
            Console.WriteLine($"Login message: {content}");
        }
    }
}
