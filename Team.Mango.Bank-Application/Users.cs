﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class Users
    {
        internal int _id { get; set; }
        internal string _username { get; set; }
        internal string _password { get; set; }

        public Users(int id, string Username, string Password)
        {
            _id = id;
            _username = Username;
            _password = Password;
        }

        public override string ToString()
        {
            return $"Id: {_id}\nName: {_username}\nPassword: {_password}";
        }
        public int getId()
        {
            return _id;
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
