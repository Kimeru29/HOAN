using System.Collections.Generic;

namespace api.Models
{
    public class Receptor : Usuario
    {
        public int Id { get; set; }
        public virtual ICollection<Emisor> Emisores { get; set; }
    }
}
