using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Domain
{
    public class Client : Person
    {
        public Client()
        {
            Accounts = new HashSet<Account>();
        }
        public string Password { get; set; } = string.Empty;
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
