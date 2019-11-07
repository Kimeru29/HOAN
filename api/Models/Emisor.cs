namespace api.Models
{
    public class Emisor : Usuario
    {
        public int Id { get; set; }
        public int ReceptorId { get; set; }

        public virtual Receptor Receptor { get; set; }
    }
}
