using MailKit;
using System;
using System.Collections.Generic;
using VulpMail.Core.UserAccounts;

namespace VulpMail.Core.DataManager
{
    public struct DeleteEmailIdentificationData
    {
        public List<UniqueId> uids;
        public UserEmailAccount currentAccount;

        public DeleteEmailIdentificationData(List<UniqueId> uids, UserEmailAccount currentAccount)
        {
            this.uids = uids;
            this.currentAccount = currentAccount;
        }
    }
}
