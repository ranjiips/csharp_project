using ExploreCSharp.SeleniumWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class Pages
    {
        private static SeleniumLoginLogoutActions _loginLogoutActionsPage;
        private static SeleniumFormActions _seleniumFormActionsPage;
        private static SeleniumJavaScriptActions _seleniumJavaScriptActionsPage;
        private static SeleniumMouseActions _seleniumMouseActionsPage;
        private static SeleniumFrames _seleniumFramesPage;
        private static SeleniumMulitpleWindows _seleniumMulitpleWindows;

        private static FileHandlingJSON _fileHandlingJSON;
        private static HandleInterfaces _handleInterfaces;


        public static SeleniumLoginLogoutActions SeleniumLoginLogoutActions => _loginLogoutActionsPage ?? (_loginLogoutActionsPage = new SeleniumLoginLogoutActions());
        public static SeleniumFormActions SeleniumFormActions => _seleniumFormActionsPage ?? (_seleniumFormActionsPage = new SeleniumFormActions());
        public static SeleniumJavaScriptActions SeleniumJavaScriptActions => _seleniumJavaScriptActionsPage ?? (_seleniumJavaScriptActionsPage = new SeleniumJavaScriptActions());
        public static SeleniumMouseActions SeleniumMouseActions => _seleniumMouseActionsPage ?? (_seleniumMouseActionsPage = new SeleniumMouseActions());
        public static SeleniumFrames SeleniumFrames => _seleniumFramesPage ?? (_seleniumFramesPage = new SeleniumFrames());
        public static SeleniumMulitpleWindows SeleniumMulitpleWindows => _seleniumMulitpleWindows ?? (_seleniumMulitpleWindows = new SeleniumMulitpleWindows());

        public static FileHandlingJSON FileHandlingJSON => _fileHandlingJSON ?? (_fileHandlingJSON = new FileHandlingJSON());
        public static HandleInterfaces HandleInterfaces => _handleInterfaces??(_handleInterfaces = new HandleInterfaces());

    }
}
