using System;
using System.Collections.Generic;

namespace _02_Builder.Exercice
{
    // Merci de coder votre solution ici
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public User(string firstname, string lastname, string email, int birthYear, int birthMonth,
            int birthDay)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            BirthYear = birthYear;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }
    }
    
    public class UserBuilder
    {
    }

}
