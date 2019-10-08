using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulpMail.Core.UserAccounts
{
    public class User
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public UserEmailAccount CurrentEmailAccount { get; set; }

        public ObservableCollection<UserEmailAccount> accounts = new ObservableCollection<UserEmailAccount>();

        public User(string userName, string passwordHash)
        {
            UserName = userName;
            PasswordHash = passwordHash;
        }

        public void AddAccount(UserEmailAccount newAccount)
        {
            accounts.Add(newAccount);
        }

        public override string ToString()
        {
            return UserName;
        }
    }
}
