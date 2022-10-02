namespace CasoPractico.Domain
{
    public class Account : BaseDomain
    {
        public Account()
        {
            Moviments = new HashSet<Moviment>();
        }
        public string Number { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public decimal InitialBalance { get; set; }
        public int IdClient { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Moviment> Moviments { get; set; }
    }
}
