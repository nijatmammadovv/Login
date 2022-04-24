using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public class User:IAccount
    {
        private static int _id;
        public int Id { get;}
        private string _Fullname;
        public string Password { get; set; }
        public string Fullname
        {
            get
            {
                return _Fullname;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    _Fullname = value;
                else
                {
                    Console.WriteLine("Fullname is wrong");
                }
            }
        }
        private string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if(!string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    _Email= value;
                else
                {
                    Console.WriteLine("Email is wrong");
                }
            }
        }
        public User()
        {
            _id++;
            Id = _id;
        }
        public User(string email,string password)
        {
            Email = email;
            Password= password;
        }
        public bool PasswordChecker(string password)
        {
            if(!String.IsNullOrEmpty(password) && !String.IsNullOrWhiteSpace(password) && password.Length >= 8)
            {
                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit  =false;
                foreach (var item in password)
                {
                    if (char.IsUpper(item)) hasUpper = true;
                    if(char.IsLower(item)) hasLower = true;
                    if(char.IsDigit(item)) hasDigit = true;

                    if(hasUpper && hasLower && hasDigit) return true;
                }
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id {Id} Fullname ==> {Fullname} Email == {Email}");
        }
    }
}
