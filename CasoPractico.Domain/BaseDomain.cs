namespace CasoPractico.Domain
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ushort Status { get; set; }
    }
}
