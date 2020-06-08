using System;
using System.Collections.Generic;
using System.Text;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student()
        {

        }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
        }

        public string GetGradeLevel()// return
        {
            string gradeLevel = " ";
            if (NumberOfCredits >= 90)
            {
                gradeLevel = "Senior";
                return gradeLevel;
            }
            else if (NumberOfCredits >= 60)
            {
                gradeLevel = "Junior";
                return gradeLevel;
            }
            else if (NumberOfCredits >= 30)
            {
                gradeLevel = "Sophomore";
                return gradeLevel;
            }
            else            
            {
                gradeLevel = "Freshman";
                return gradeLevel;
            }
        }
    }
}
