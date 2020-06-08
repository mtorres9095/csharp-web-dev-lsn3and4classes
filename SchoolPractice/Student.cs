using System;
using System.Collections.Generic;
using System.Text;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
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
        public Student(string name, int studentId)
              : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            double newGpa = ((Gpa * NumberOfCredits) + (courseCredits * grade)) / (NumberOfCredits + courseCredits);
            int newNumberOfCredits = NumberOfCredits + courseCredits;
            Gpa = newGpa;
            NumberOfCredits = newNumberOfCredits;


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
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
        public override boolean Equals(object toBeCompared)// 5.3.2.1.2 Problem #2
        {

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }

    }
}
