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
        private string _firstname;
        private string _lastname;
        private string _email;
        private int _birthyear;
        private int _birthmonth;
        private int _birthday;
        public UserBuilder WithFirstname(string firstname)
        {
            _firstname = firstname;
            return this;
        }

        public User Build()
        {
            if (!string.IsNullOrEmpty(_email) && !string.IsNullOrEmpty(_firstname) && !string.IsNullOrEmpty(_lastname) &&
                _birthday > 0 && _birthyear > 0 && _birthmonth > 0)
            {
                return new User(_firstname, _lastname, _email,
                    _birthyear, _birthmonth, _birthday);
            }
            
            throw new Exception("You must set all the parameters");
        }

        public UserBuilder WithLastname(string lastname)
        {
            _lastname = lastname;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }

        public UserBuilder WithBirthYear(int birthYear)
        {
            _birthyear = birthYear;
            return this;
        }

        public UserBuilder WithBirthMonth(int birthMonth)
        {
            _birthmonth = birthMonth;
            return this;
        }
        
        public UserBuilder WithBirthDay(int birthDay)
        {
            _birthday = birthDay;
            return this;
        }
    }

}
