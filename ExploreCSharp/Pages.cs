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
        private static ExploreLinq _exploreLinq;
        private static FileHandlingCSV _fileHandlingCSV;
        private static FileHandlingExcel _fileHandlingExcel;
        private static SamplePrograms _samplePrograms;
        private static Polymorphism _polymorphism;
        private static Encapsulation _encapsulation;
        private static StringOperations _stringOperations;
        private static GenericCollections _genericCollections;
        private static HandleAPIs _handleAPIs;


        public static SeleniumLoginLogoutActions SeleniumLoginLogoutActions => _loginLogoutActionsPage ?? (_loginLogoutActionsPage = new SeleniumLoginLogoutActions());
        public static SeleniumFormActions SeleniumFormActions => _seleniumFormActionsPage ?? (_seleniumFormActionsPage = new SeleniumFormActions());
        public static SeleniumJavaScriptActions SeleniumJavaScriptActions => _seleniumJavaScriptActionsPage ?? (_seleniumJavaScriptActionsPage = new SeleniumJavaScriptActions());
        public static SeleniumMouseActions SeleniumMouseActions => _seleniumMouseActionsPage ?? (_seleniumMouseActionsPage = new SeleniumMouseActions());
        public static SeleniumFrames SeleniumFrames => _seleniumFramesPage ?? (_seleniumFramesPage = new SeleniumFrames());
        public static SeleniumMulitpleWindows SeleniumMulitpleWindows => _seleniumMulitpleWindows ?? (_seleniumMulitpleWindows = new SeleniumMulitpleWindows());

        public static FileHandlingJSON FileHandlingJSON => _fileHandlingJSON ?? (_fileHandlingJSON = new FileHandlingJSON());
        public static HandleInterfaces HandleInterfaces => _handleInterfaces??(_handleInterfaces = new HandleInterfaces());
        public static ExploreLinq ExploreLinq => _exploreLinq ?? (_exploreLinq = new ExploreLinq());
        public static FileHandlingCSV FileHandlingCSV => _fileHandlingCSV ?? (_fileHandlingCSV = new FileHandlingCSV());
        public static FileHandlingExcel FileHandlingExcel => _fileHandlingExcel ?? (_fileHandlingExcel = new FileHandlingExcel());
        public static Polymorphism Polymorphism => _polymorphism??(_polymorphism = new Polymorphism());
        public static Encapsulation Encapsulation => _encapsulation??(_encapsulation = new Encapsulation());
        public static StringOperations StringOperations => _stringOperations??(_stringOperations = new StringOperations());
        public static GenericCollections GenericCollections => _genericCollections??(_genericCollections = new GenericCollections());
        //public static HandleAPIs HandleAPIs => _handleAPIs??(_handleAPIs=new HandleAPIs());
        public static HandleAPIs HandleAPIs => _handleAPIs??new HandleAPIs();
        public static SamplePrograms SamplePrograms => _samplePrograms??(_samplePrograms = new SamplePrograms());

    }
}
