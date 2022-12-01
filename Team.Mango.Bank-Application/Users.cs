using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class Users
    {
        
        internal string _username { get; set; }
        internal string _password { get; set; }
       

        public Users(string Username, string Password)
        {
            
            _username = Username;
            _password = Password;
           
        }

        public override string ToString()
        {
            return $"Name: {_username}\nPassword: {_password}";
        }
       
        public string getUsername()
        {
            return _username;
        }
        public string getpw()
        {
            return _password;
        }
       
    }
}
