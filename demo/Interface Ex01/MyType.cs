using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface_Ex01
{
    internal class MyType : IMyType /* : => impelement */
    {
        public double Salary { get ; set ; }

        public void myfun()
        {
            Console.WriteLine("Hallo World");
        }
    }
}
