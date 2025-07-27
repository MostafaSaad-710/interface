using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.interface_Ex03
{
    internal class Car : IMoveable
    {
        public int Speed { get  ;set ; }

        public void Backward()
        {
            Console.WriteLine("Car IMoveable Backword");        
        }

        public void Forward()
        {
            Console.WriteLine("Car IMoveable Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car IMoveable Right");
        }
    }
}
