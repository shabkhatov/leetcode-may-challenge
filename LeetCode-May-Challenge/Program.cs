using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day31_Edit_Distance().MinDistance("intention", "execution");
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    