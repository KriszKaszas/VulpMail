using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VulpMail.Core.DataManager;
using VulpMail.Core.UserAccounts;

namespace VulpMail.View.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            users.CurrentUser.UserName = "Krisz";
            users.CurrentUser.PasswordHash = "";
            var currentAccount = new UserEmailAccount("imap.gmail.com", 993, "saintsender2.0@gmail.com", "atssddvndnffxggx");
            users.CurrentUser.CurrentEmailAccount = currentAccount;
        }

        public bool IsEmailValid(string emailAddress)
        {
            return inboundEmails.ValidateEmailFormat(emailAddress);
        }

        public void GetUserEmails(UserEmailAccount currentAccount)
        {
            inboundEmails.StartGettingMessages(currentAccount);
        }

        public void AddNewUser(User user)
        {
            users.AddUser(user);
        }

        public void RemoveUser()
        {
            users.RemoveUser();
        }

    }
}
