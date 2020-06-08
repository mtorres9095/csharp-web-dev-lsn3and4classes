using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string CourseDesc { get; set; }
        public List<Student> Roster { get; set; }
        public Teacher instructor;

        public Course()
        {

        }
        public override boolean Equals(object toBeCompared)//5.3.2.1.1. Problem #1 
        {
            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }
        Student bono1 = new Student("Paul David Hewson", 4);
        Student bono2 = new Student("Bono", 4);
        if (bono1.Equals(bono2))
            {
            Console.WriteLine(bono1.Name + " is the same as " + bono2.Name);
            }
}
}
}
