using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Task2Class
{
    internal class Admin : User
    {
        public bool IssuperAdmin { get; set; }
        public string Section { get; set; }

        public Admin(string username, string password, bool superadmin, string section)

        {
            UserName = username;
            Password = password;
            IssuperAdmin = superadmin;
            Section = section;

        }

        public void Show()
        {
            Console.WriteLine($"Username: {UserName} Password: {Password} IssuperAdmin: {IssuperAdmin} Section: {Section}");
        }

    }
}
