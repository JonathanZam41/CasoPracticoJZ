using CasoPractico.Domain;

namespace CasoPractico.Application.DTO.Accounts
{
    [Serializable]
    public record AccountDto
    {
        public string Number { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public decimal InitialBalance { get; set; }
    }
}
