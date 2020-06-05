using System;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsOfTeaching { get; set; }
        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, string subject, int yearsOfTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsOfTeaching = yearsOfTeaching;
        }

    }
}
