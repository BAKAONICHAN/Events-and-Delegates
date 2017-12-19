using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFramework;

namespace ExtencionMethods
{
    public static class Util
    {
        public static void CallAll(OperationServise servise)
        {

            servise.Operation1();
            servise.Operation2();
            servise.Operation3();

        }
    }
}
