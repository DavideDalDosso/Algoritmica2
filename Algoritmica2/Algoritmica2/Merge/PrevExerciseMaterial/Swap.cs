﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Swap
{
    public static void Execute<T>(ref T a, ref T b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}
