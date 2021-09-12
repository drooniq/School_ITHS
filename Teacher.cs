using System;

namespace School_ITHS
{
    class Teacher : Person
    {
        public bool IsAdmin { get; set; }
        private AdminLevel adminLevel;

        public Teacher(string firstName, string lastName, int age, string email, string password) : base(firstName, lastName, age, email, password)
        {
            IsAdmin = false;
            adminLevel = AdminLevel.NoAdmin;
        }

        public Teacher(string firstName, string lastName, int age, string email, string password, AdminLevel adminLevel) : base(firstName, lastName, age, email, password)
        {
            if (adminLevel == AdminLevel.NoAdmin)
            {
                IsAdmin = false;
            }
            IsAdmin = true;
        }

        public override string ToString()
        {
            return base.ToString() + "Is also a teacher" + ((IsAdmin)?" with admin level {adminLevel}\n":"\n");
        }
    }
}
