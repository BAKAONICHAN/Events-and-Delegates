using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFramework;
using static System.Console;

namespace ExtencionMethods
{
    public static class OperationServiceExterntions
    {
        public static void DoAll(this OperationServise service)
        {
            service.Operation1();
            service.Operation2();
            service.Operation3();
        }
    }
}
