using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface_Ex02
{
    internal class SeriesByThree : ISeries
    {

        public int Current { get; set; } //0

        public void next()
        {
            Current += 3;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}

    }
}
