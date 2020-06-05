using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student miguel = new Student("Miguel", 1 ,1 , 4.0);
            Console.WriteLine($"Testing the class {miguel.Name} is here");

            

        }
    }
    
}
