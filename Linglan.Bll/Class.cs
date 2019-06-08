using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linglan.IBll;

namespace Linglan.Bll
{
    public class Class : IClass
    {
        public void ShowInfo()
        {
            Console.WriteLine("this Class:ShowInfo()");
        }
    }
}
