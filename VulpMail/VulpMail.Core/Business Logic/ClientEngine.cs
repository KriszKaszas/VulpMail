using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VulpMail.Core.DataManager;
using VulpMail.Core.UserAccounts;

namespace VulpMail.Core.Business_Logic
{
    class ClientEngine
    {
        public AllUsers RegisteredUsers { get; set; }
        public InboundEmails InboundEmailManager { get; set; }

        public ClientEngine()
        {
            RegisteredUsers = new AllUsers();
            InboundEmailManager = new InboundEmails();
        }

    }
}
