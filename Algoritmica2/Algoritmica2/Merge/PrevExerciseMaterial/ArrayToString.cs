using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayToString
{
    public static string Execute<T>(T[] arr)
    {
        string result = "{";

        for(int i=0; i<arr.Length; i++)
        {
            result += arr[i];
            if(i == arr.Length - 1) result += "}";
            else result += ", ";
        }

        return result;
    }
}
