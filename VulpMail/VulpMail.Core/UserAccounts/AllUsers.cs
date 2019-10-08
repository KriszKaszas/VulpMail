using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulpMail.Core.UserAccounts
{
    public class AllUsers
    {
        public User CurrentUser { get; set; }

        public ObservableCollection<User> RegisteredUsers { get; } = new ObservableCollection<User>();

        public void AddUser(User user)
        {
            RegisteredUsers.Add(user);
            CurrentUser = user;
        }

        public void AddAccountToUser(UserEmailAccount newAccount)
        {
            CurrentUser.AddAccount(newAccount);
        }

        public void RemoveUser()
        {
            RegisteredUsers.Remove(CurrentUser);
            CurrentUser = null;
        }

        public void DeleteAccount(UserEmailAccount account)
        {
            CurrentUser.accounts.Remove(account);
        }
    }
}
