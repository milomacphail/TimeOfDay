﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{



    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            Console.WriteLine(n + " x " + multiplier + " = " + (multiplier * n));
        }
    }
}
