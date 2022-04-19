using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Diretor
    {
        public Diretor()
        {
            Filmes = new HashSet<Filme>();
        }

        public int CodDiretor { get; set; }
        public string NomeDiretor { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
    }
}
