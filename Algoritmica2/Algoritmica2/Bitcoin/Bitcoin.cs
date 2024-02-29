using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bitcoin
{
    public void AddValue(float value)
    {
        if (value < 0)
        {
            Console.WriteLine("Error: not a positive value");
            return;
        }
    }
}
