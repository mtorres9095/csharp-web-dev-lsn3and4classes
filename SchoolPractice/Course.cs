using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string CourseDesc { get; set; }
        public List<Student> Roster { get; set; }
        public Teacher Instructor;

        public Course()
        {

        }
        public override string ToString()
        {
            return $"Course: {CourseDesc}, teacher: {Instructor}";
        }
        public override bool Equals(object toBeCompared)//5.3.2.1.1. Problem #1 
        {
            if (this == toBeCompared)
            {
                return true;
            }
            if (toBeCompared == null)
            {
                return false;
            }
            if (this.GetType() != toBeCompared.GetType())
            {
                return false;
            }
           Course courseObj = toBeCompared as Course;
            return Instructor == courseObj.Instructor && CourseDesc == courseObj.CourseDesc;

        }

    }
}

