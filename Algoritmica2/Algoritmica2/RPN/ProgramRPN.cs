using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramRPN
{
    public static void Main(string[] args)
    {
        Console.WriteLine(RPNCalculator.Calculate("./RPN \"8 9 * 9 - 9 - 9 - 4 - 1 +\""));
        Console.WriteLine(RPNCalculator.Calculate("./RPN \"7 7 * 7 -\""));
        Console.WriteLine(RPNCalculator.Calculate("./RPN \"1 2 * 2 / 2 * 2 4 - +\""));
        Console.WriteLine(RPNCalculator.Calculate("./RPN \"(1 + 1)\""));
        Console.WriteLine(RPNCalculator.Calculate("./RPN \"7 7 * -\""));
        Console.WriteLine(RPNCalculator.Calculate("./RPN \"8 9\""));
    }
}
