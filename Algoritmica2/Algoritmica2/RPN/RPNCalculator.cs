using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RPNCalculator
{
    public static float? Calculate(string rpn)
    {
        rpn = rpn.Replace("\"", "");
        string[] splitRPN = rpn.Split(' ');

        if(splitRPN.Length < 4)
        {
            Console.WriteLine($"STRING: {rpn} ERROR: Not enough parameters");
            return null;
        }
        if(splitRPN.Length % 2 == 1)
        {
            Console.WriteLine($"STRING: {rpn} ERROR: Parameters are uneven");
            return null;
        }
        if (splitRPN[0] != "./RPN")
        {
            Console.WriteLine($"STRING: {rpn} ERROR: Command is invalid. Please use ./RPN");
            return null;
        }

        Stack<float> stack = new Stack<float>();

        int i = 2;

        if (float.TryParse(splitRPN[1], out float result1))
        {
            stack.Push(result1);
        } else
        {
            Console.WriteLine($"STRING: {rpn} ERROR: Parameter {1} is not a number");
            return null;
        }

        while (i < splitRPN.Count())
        {
            
            switch (splitRPN[i])
            {
                case "+":
                    var temp = stack.Pop();
                    stack.Push(stack.Pop()+temp);
                    break;
                case "-":
                    var temp1 = stack.Pop();
                    stack.Push(stack.Pop() - temp1);
                    break;
                case "/":
                    var temp2 = stack.Pop();
                    stack.Push(stack.Pop() / temp2);
                    break;
                case "*":
                    var temp3 = stack.Pop();
                    stack.Push(stack.Pop() * temp3);
                    break;
                default:
                    if (float.TryParse(splitRPN[i], out float result2))
                    {
                        stack.Push(result2);
                    }
                    else
                    {
                        Console.WriteLine($"STRING: {rpn} ERROR: Parameter {i} is not a number");
                        return null;
                    }
                    break;
            }
            i++;
        }

        return stack.Pop();
    }
}
