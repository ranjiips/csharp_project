using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploreCSharp
{
    [TestClass]
    public class UnitTestingClass
    {
        [TestInitialize]
        public void InitializeMethod()
        {
            Console.WriteLine("Executing the Initialize method");
            string baseurl = "https://the-internet.herokuapp.com/";
            Pages.SeleniumLoginLogoutActions.NavigateToURL(baseurl);
        }

        [TestMethod]
        public void TestCase1()
        {
            Console.WriteLine("Executing Test Case 1");
            Pages.SeleniumLoginLogoutActions.LoginPageUsingFormAuthentication("Form Authentication");
        }

        [TestMethod]
        public void TestCase2()
        {
            Console.WriteLine("Executing Test Case 2");
            Pages.SeleniumLoginLogoutActions.LoginPageUsingFormAuthentication("Checkboxes");
        }

        [TestMethod]
        public void TestCase3()
        {
            Console.WriteLine("Executing Test Case 3");
            Pages.SeleniumLoginLogoutActions.LoginPageUsingFormAuthentication("HandleDragDrop");
        }
    }
}
