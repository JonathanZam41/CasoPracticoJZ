namespace CasoPractico.Application.DTO.Clients
{
    [Serializable]
    public record ClientDto
    {
        public string Name { get; init; } = string.Empty;
        public int? Gender { get; init; }
        public int Age { get; init; }
        public string Identification { get; init; } = string.Empty;
        public string Address { get; init; } = string.Empty;
        public string Phone { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;
    }
}
