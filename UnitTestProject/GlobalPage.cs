using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;

namespace UnitTestProject
{
    public class GlobalPage
    {
        internal static IWebDriver Driver;
        private static GlobalPage _global;
        public static string _browser;
        private static string _baseUrl;
        private static string _userName;
        private static string _password;
        private static int _seleniumLongTimeOut;
        private static int _seleniumPageLoadTimeOut;
        private static string _company;
        private static string _automationTitle;

        public GlobalPage()
        {

        }
        public static GlobalPage GetGlobal()
        {
            if (_global == null)
            {
                return _global = new GlobalPage();
            }

            return _global;
        }

        public string Browser
        {
            get
            {
                //_browser = ConfigurationManager.AppSettings["Browser"].Trim();
                _browser = "chrome";
                if (!string.IsNullOrWhiteSpace(_browser))
                    return _browser;
                else
                    Console.WriteLine("\t\tMissing browser info.");
                return _browser;
            }
            set
            {
                _browser = "chrome";
                Console.WriteLine(@"\t\tMissing browser info. Default to {$_browser}");
            }
        }

        public string BaseURL
        {
            get
            {
                //_baseUrl = ConfigurationManager.AppSettings["URL"].Trim();
                _baseUrl = "https://www.vista.adp.com/ESS4/ESSV5/dashboard";
                if (!string.IsNullOrWhiteSpace(_baseUrl))
                    return _baseUrl;
                else
                    throw new ArgumentNullException("\t\tMissing base Url info.");
            }
            set
            {
                _baseUrl = value;
            }
        }

        public string LoginUserName
        {
            get
            {
                //_userName = ConfigurationManager.AppSettings["EmpID"].Trim();
                _userName = "04027";
                if (!string.IsNullOrWhiteSpace(_userName))
                    return _userName;
                else
                    throw new ArgumentNullException("\t\tMissing EmpID info.");
            }
            set
            {
                _userName = value;
            }
        }

        public string LoginPassword
        {
            get
            {
                //_password = ConfigurationManager.AppSettings["Password"].Trim();
                _password = "Sentha@2021";
                if (!string.IsNullOrWhiteSpace(_password))
                    return _password;
                else
                    throw new ArgumentNullException("\t\tMissing Password info.");
            }
            set
            {
                _password = value;
            }
        }

        public static int SeleniumLongTimeOut
        {
            get
            {
                _seleniumLongTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings["SeleniumLongTimeOut"]);
                if (_seleniumLongTimeOut != 0)
                    return _seleniumLongTimeOut;
                else
                    Console.WriteLine("\t\tMissing browser info.");
                return _seleniumLongTimeOut;
            }
            set
            {
                _seleniumLongTimeOut = 10;
                Console.WriteLine(@"\t\tMissing browser info. Default to {_seleniumLongTimeOut}");
            }
        }

        public static int SeleniumPageLoadTimeOut
        {
            get
            {
                _seleniumPageLoadTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings["SeleniumPageLoadTimeOut"]);
                if (_seleniumPageLoadTimeOut != 0)
                    return _seleniumPageLoadTimeOut;
                else
                    Console.WriteLine("\t\tMissing seleniumPageLoadTimeOut info.");
                return _seleniumPageLoadTimeOut;
            }
            set
            {
                _seleniumPageLoadTimeOut = 60;
                Console.WriteLine(@"\t\tMissing seleniumPageLoadTimeOut info. Default to {_seleniumPageLoadTimeOut}");
            }
        }

        public string Company
        {
            get
            {
                _company = ConfigurationManager.AppSettings["Company"].Trim();
                if (!string.IsNullOrWhiteSpace(_company))
                    return _company;
                else
                    throw new ArgumentNullException("\t\tMissing Company info.");
            }
            set
            {
                _company = value;
            }
        }

        public string AutomationTitle
        {
            get
            {
                _automationTitle = ConfigurationManager.AppSettings["Password"].Trim();
                if (!string.IsNullOrWhiteSpace(_automationTitle))
                    return _automationTitle;
                else
                    throw new ArgumentNullException("\t\tMissing AutomationTitle info.");
            }
            set
            {
                _automationTitle = value;
            }
        }
    }
}
