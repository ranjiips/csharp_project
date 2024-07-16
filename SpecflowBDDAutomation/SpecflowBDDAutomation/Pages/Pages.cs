using SpecflowBDDAutomation.Pages.ProductStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowBDDAutomation.Hooks;

namespace SpecflowBDDAutomation.Pages
{
    public class Pages
    {
        private static PS_Signup ps_signup;
        private static BaseWebDriver _baseWebDriver;

        public static PS_Signup PS_Signup => ps_signup ?? (ps_signup = new PS_Signup());
        public static BaseWebDriver BaseWebDriver => _baseWebDriver ?? (_baseWebDriver = new BaseWebDriver());
    }
}
