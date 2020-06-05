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
        


    }
}
