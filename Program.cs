using System;

namespace School_ITHS
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School("IT Högskolan");

            school.AddPerson(new Person("Magnus", "Nilsson", 45, "magnus.nilsson@iths.se", "HELP_ME!"));
            school.AddPerson(new Student("Sara", "Andersson", 22, "sara.andersson@iths.se", "Dont't remember", Grade.A));
            school.AddPerson(new Teacher("Linus", "Johansson", 35, "linus.johansson@iths.se", "ListList@Help"));
            school.AddPerson(new Person("Katarina", "Persson", 55, "katarina.persson@iths.se", "1234567890"));
            school.AddPerson(new Teacher("Jens", "Palmqvist", 30, "jens.palmqvist@iths.se", "ListList@Help", AdminLevel.SuperAdmin));

            school.DisplayAllSchoolMembers();

            Console.WriteLine("------ Teachers ---------");
            Console.ForegroundColor = ConsoleColor.Green;
            school.DisplayOnlyTeachers();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
