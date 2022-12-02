using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Team.Mango.Bank_Application
{
    public class User
    {   // User Constructs
        // We need to make bankaccount in a list
        private string _UserName;
        private string _Password;
        private string _FirstName;
        private string _LastName;
        private int _PhoneNum;
        private List<BankAccount> _BankAccountList;

        // True or false if Admin
        private bool _Admin;

       
        public User(string username, string password, string firstname,string lastname, int phonenum, List<BankAccount> BankAccountList = null)
        {
            
            this._UserName = username;
            this._Password = password;
            this._FirstName = firstname;
            this._LastName = lastname;
            this._PhoneNum = phonenum;
            this._BankAccountList = BankAccountList;




        }

        // Private construct
        public string Username
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string Firstname
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string Lastname
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public int PhoneNum
        {
            get { return _PhoneNum; }
            set { _PhoneNum = value; }
        }

        public List<BankAccount> BankAccountList
        {
            get { return _BankAccountList; }
            set { _BankAccountList = value; }
        }

        public bool Admin
        {
            get { return _Admin; }
            set { _Admin = value; }
        }

        //public override string ToString()
        //{
        //    return $"Name: {_username}\nPassword: {_password}";
        //}

        //public string getUsername()
        //{
        //    return _username;
        //}
        //public string getpw()
        //{
        //    return _password;
        //}

    }
}
