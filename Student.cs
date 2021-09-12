using System;

namespace School_ITHS
{
    class Student : Person
    {
        public Grade Grade { get; set; }
        public Student(string firstName, string lastName, int age, string email, string password, Grade grade) : base (firstName, lastName, age, email, password)
        {
            Grade = grade;
        }
        public override string ToString()
        {
            return base.ToString()+$"Has current grade: {Grade}\n";
        }
    }
}
