namespace CasoPractico.Application.DTO.Clients
{
    [Serializable]
    public record ClientForCreationDto : ClientDto
    {
        public string CreatedBy { get; init; } = string.Empty;       
    }
}
