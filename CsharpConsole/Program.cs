using System;
using System.Collections.Generic;
using AccessModifiersClasses;
using ClassLibrary1;

namespace CsharpConsole
{
    public class Program
    {

        
        static void Main(string[] args)
        {
            ////Handle Calculator class- params keyword
            //StaticMethods.UseParams();

            ////Hanlde out modifier
            //StaticMethods.UseOutModifier();

            ////Handle ref modifier
            //int a = 12;
            //StaticMethods.UseRefModifier(ref a);
            //Console.WriteLine("Final value: {0}", a);

            ////Divide 2 numbers and return quotient and remainder using REF and OUT keyword
            //StaticMethods.UsingRefOutModifier();

            //StaticMethods.DataTypes();
            //StaticMethods.ControlStatments();
            //StaticMethods.HandlePersonClass();
            //StaticMethods.HandleCustomerClass();
            //StaticMethods.HandleOverloading();
            //StaticMethods.HandleAccessModifiers();
            //StaticMethods.HandleStringManipulations();

            ////APIs
            ////StaticMethods.Handle_API_Methods();

            ////Collections
            //StaticMethods.HandleCollections();

            LinqClass lq = new LinqClass();
            lq.SortTheNumbers();
            lq.GetMinimumValue();
            lq.GetMaximumValue();
            lq.GetListCount();
            lq.GetEvenNumbersFromTheList();
            lq.GetvalueFromNthPoistion(2);
            lq.GetTheHighestNumberBasedOnGivenPosition(3);
            lq.GetMobileByPrice(3000);
            lq.SortMobileByPriceAndSAR();
            lq.ReverseTheNumberList();
        }        
    }
}
