using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Task2Class
{
    internal class User
    {
        private string _username;
        private string _password;
        public string UserName
        {
            get { return _username; }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }

            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (GetPassword(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Sehv");
                }
            }
        }

      

        public  bool GetPassword(string pasw)
        {
            bool hasdigit = false;
            bool hasleter=false;

            foreach (var item in pasw)
            {
                if (char.IsDigit(item))
                {
                    hasdigit = true;
                }
                if (char.IsLetter(item))
                {
                    hasleter = true;
                }
            }
           bool result=hasdigit&& hasleter;
            return result;
        }
    }
}