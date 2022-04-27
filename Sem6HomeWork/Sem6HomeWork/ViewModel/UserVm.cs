using Sem6HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Sem6HomeWork.ViewModel
{
    internal class UserVm
    {
        public ObservableCollection<UserGroupM> UserList { get; set; }
        public UserVm()
        {
            this.UserList = new ObservableCollection<UserGroupM>();
            var group1 = new List<User>
            {
                new User("Carlos","Gallardo",21),
                new User("Enrique","Ambrosio",21),
                new User("Marian","Androba",22)
            };
            UserList.Add(new UserGroupM("GROUP1", group1));
            var group2 = new List<User>
            {
                new User("Antony","Marcus",21),
                new User("Henrry","Andres",21),
                new User("Jack","Squeleton",22)
            };
            UserList.Add(new UserGroupM("GROUP2", group2));
            var group3 = new List<User>
            {
                new User("Martin","Anfonzo",21),
                new User("Tobby","Macarius",21),
                new User("Alex","Sanchez",22)
            };
            UserList.Add(new UserGroupM("GROUP3", group3));
        }
    }
}
