﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.interface_Ex03
{
    internal interface IFlyable
    {
        int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();

    }
}
