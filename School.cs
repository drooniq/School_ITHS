using System;
using System.Collections.Generic;
using System.Linq;

namespace School_ITHS
{
    class School
    {
        public string Name { get; set; }
        public List<Person> people { get; set; }

        public School( string schoolName )
        {
            Name = schoolName;
            people = new List<Person>();
        }

        public void AddPerson( Person person )
        {
            people.Add(person);
        }

        public void DisplayAllSchoolMembers()
        {
            Console.WriteLine($"---- {Name} ------------------------ ");
            people.ForEach(i => Console.WriteLine($"{i}"));
        }

        public void DisplayOnlyTeachers()
        {
            var teacherList = people.Where(pers => (pers is Teacher));
            teacherList.ToList().ForEach(i => Console.WriteLine($"{i}"));
        }
    }
}
