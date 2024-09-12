using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops2
{
    internal interface IBill
    {
        static int count = 0;
        double Amount { get; set; }

        void SetName(string Name);

        void SetCount()
        {
            Console.WriteLine(count);
        }

    }
}
