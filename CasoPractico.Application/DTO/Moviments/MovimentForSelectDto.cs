using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Application.DTO.Moviments
{
    [Serializable]
    public record MovimentForSelectDto : MovimentDto
    {
        public string ClientNames { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountType { get; set; } = string.Empty;
        public decimal InitialBalance { get; set; }
        public ushort Status { get; set; }
    }
}
