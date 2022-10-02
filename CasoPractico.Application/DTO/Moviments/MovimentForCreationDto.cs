namespace CasoPractico.Application.DTO.Moviments
{
    [Serializable]
    public record MovimentForCreationDto : MovimentDto
    {
        public string CreatedBy { get; init; } = string.Empty;
    }
}
