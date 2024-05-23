using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DemoInternal
    {
        public void MakeDemoCalls()
        {
            AccessModifiersLibrary obj = new AccessModifiersLibrary();
            obj.InternalDemo();
        }
    }
}
