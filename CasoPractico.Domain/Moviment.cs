using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Domain
{
    public class Moviment : BaseDomain
    {
        public DateTime Date { get; set; }
        public string Type { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public decimal Balance { get; set; }
        public int IdAccount { get; set; }
        public virtual Account Account { get; set; }
    }
}
