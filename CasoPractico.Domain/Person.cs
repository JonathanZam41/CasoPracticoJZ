namespace CasoPractico.Domain
{
    public abstract class Person : BaseDomain
    {
        public string Name { get; set; } = string.Empty;
        public int? Gender { get; set; }
        public int Age { get; set; }
        public string Identification { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty ;
    }
}
