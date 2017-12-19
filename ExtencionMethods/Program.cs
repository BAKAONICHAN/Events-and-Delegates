using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using SuperFramework;

namespace ExtencionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationServise servise = new OperationServise();
            Util.CallAll(servise);
            servise.DoAll();
            ReadLine();
        }
    }
}
