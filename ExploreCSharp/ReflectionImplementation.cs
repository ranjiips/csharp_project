using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class ReflectionImplementation
    {
        public void GetAssembelyType()
        {
            string dllPath = @"E:\Projects\GitRepo\csharp_project\ExploreCSharp\bin\Debug\net5.0\ExploreCSharp.dll";

            Assembly assembly = Assembly.LoadFile(dllPath);
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Class: {type.Name}");
                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine($"--- Method: {method.Name}");
                    ParameterInfo[] parameter = method.GetParameters();
                    foreach (var param in parameter)
                    {
                        Console.WriteLine($" --- Parameter: {param.Name} : {param.ParameterType}");
                    }
                }
            }
        }
    }
}
