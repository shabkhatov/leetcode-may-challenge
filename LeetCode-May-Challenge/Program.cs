using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day28_Counting_Bits().CountBits(33);

            Console.WriteLine("Result " + result);
            foreach (var v in result) {
                Console.WriteLine(v);
            }
            Console.Read();
        }
    }
}
    