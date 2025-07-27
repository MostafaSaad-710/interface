using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface_Ex01
{
    internal interface IMyType
    {
        // What Can Write Inside The Interface:
        // 1. Signature Of Properties
        // 2. Signature Of Methods [Name, Parameter, Return Type]
        // 3. Default Implemented Methods [Fully Implemented Methods]


        // Signature Of Methods [Name, Parameter, Return Type]
        void myfun();

        // Signature Of Properties
        double Salary { get; set; }

        // Default Implemented Methods [Fully Implemented Methods]
        void Print()
        {
            Console.WriteLine("Default Implemented Methods [Fully Implemented Methods]");
        }



    }
}
