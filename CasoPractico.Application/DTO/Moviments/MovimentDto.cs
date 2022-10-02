namespace CasoPractico.Application.DTO.Moviments
{
    [Serializable]
    public record MovimentDto
    {
        public DateTime Date { get; set; }
        public string Type { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public decimal Balance { get; set; }
        public int IdAccount { get; set; }
    }
}
