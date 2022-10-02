using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Application.DTO.Accounts
{
    [Serializable]
    public record AccountForSelectDto : AccountDto
    {
        public string ClientNames { get; set; } = string.Empty;
    }
}
