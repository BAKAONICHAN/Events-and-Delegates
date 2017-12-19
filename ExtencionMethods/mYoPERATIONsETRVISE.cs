using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFramework;

namespace ExtencionMethods
{
 public    class mYoPERATIONsETRVISE
    {
        OperationServise service;
        public mYoPERATIONsETRVISE()
        {
            service = new OperationServise();
        }
        public void DoALL()
        {
            service.Operation1();
            service.Operation2();
            service.Operation3();
        }
    }
}
