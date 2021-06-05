using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.ProxyDP
{
    public enum role
    {
        CEO = 1,
        MANAGER = 2,
        Developer = 3
    }
    public class Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public role Role { get; set; }
        public Person(string username, string password, role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
