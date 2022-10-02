namespace CasoPractico.Application.DTO.Accounts
{
    [Serializable]
    public record AccountForCreationDto : AccountDto
    {
        public string? CreatedBy { get; set; }
        public int IdClient { get; set; }
    }
}
