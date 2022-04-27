using System;
using System.Collections.Generic;
using System.Text;

namespace Sem6HomeWork.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public User(string name, string lastname, int age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }
    }
    internal class UserGroupM : List<User>
    {
        public string GroupName { get; private set; }
        public UserGroupM(string groupname, List<User> source) : base(source)
        {
            GroupName = groupname;
        }
        
    }
}
