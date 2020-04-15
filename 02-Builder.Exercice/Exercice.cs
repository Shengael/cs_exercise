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

        public User()
        {
            Firstname = "";
            Lastname = "";
            Email = "";
            BirthYear = 0;
            BirthMonth = 0;
            BirthDay = 0;
        }
    }
    
    public class UserBuilder
    {
        private User user;
        
        public UserBuilder() 
        {
            user = new User();
        }
        public UserBuilder WithFirstname(string firstname)
        {
            user.Firstname = firstname;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }

}
