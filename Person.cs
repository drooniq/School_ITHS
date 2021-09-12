using System;

namespace School_ITHS
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Person()
        {
        }

        public Person (string firstName, string lastName, int age, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"[{base.ToString().Split(".")[1]}]:\n" + $"Firstname={FirstName}\nLastname={LastName}\nAge={Age}\nEmail = {Email}\nPassword ={Password}\n";
        }
    }
}
