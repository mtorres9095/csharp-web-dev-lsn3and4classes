using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student miguel = new Student("Miguel", 1 ,89 , 4.0);
            
            Console.WriteLine($"Testing the class {miguel.Name} is here and is a {miguel.GetGradeLevel()} he has a GPA of {miguel.Gpa}");
            miguel.AddGrade(4, 3.75);
            Console.WriteLine($"The new GPA is {miguel.Gpa} and {miguel.NumberOfCredits} credits he is now a {miguel.GetGradeLevel()}");
            Student person = new Student("Cristobal");
            Console.WriteLine(person.ToString());


        }
    }
    
}
