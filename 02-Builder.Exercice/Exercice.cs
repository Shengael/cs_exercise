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
            if (user.Email.Length > 0 && user.Firstname.Length > 0 && user.Lastname.Length > 0 &&
                user.BirthDay > 0 && user.BirthYear > 0 && user.BirthMonth > 0)
            {
                return user;
            }
            
            throw new Exception("You must set all the parameters");
        }

        public UserBuilder WithLastname(string lastname)
        {
            user.Lastname = lastname;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            user.Email = email;
            return this;
        }

        public UserBuilder WithBirthYear(int birthYear)
        {
            user.BirthYear = birthYear;
            return this;
        }

        public UserBuilder WithBirthMonth(int birthMonth)
        {
            user.BirthMonth = birthMonth;
            return this;
        }
        
        public UserBuilder WithBirthDay(int birthDay)
        {
            user.BirthDay = birthDay;
            return this;
        }
    }

}
