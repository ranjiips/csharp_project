using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTestProject.Hooks;

namespace MSTestProject.Pages
{
    public class Page
    {
        public static BaseWebPage _basewebpage;
        public static HomePage _homepage;
        public static LoginPage _loginpage;

        public static BaseWebPage BaseWebPage => _basewebpage ?? (_basewebpage = new BaseWebPage());
        public static HomePage HomePage => _homepage ?? (_homepage = new HomePage());
        public static LoginPage LoginPage => _loginpage ?? (_loginpage = new LoginPage());
    }
}
