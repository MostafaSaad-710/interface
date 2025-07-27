using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.interface_Ex03
{
    internal class Airplane : IMoveable , IFlyable
    {
         int IMoveable.Speed { get; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine("Airplane IMoveable Backword");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Airplane IMoveable Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airplane IMoveable Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airplane IMoveable Right");
        }

        int IFlyable.Speed { get; set; }

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane IFlyable Backword");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane IFlyable Forward");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplane IFlyable Left");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplane IFlyable Right");
        }
    }
}
