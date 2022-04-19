using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Filmes = new HashSet<Filme>();
        }

        public int CodFornecedor { get; set; }
        public string NomeFornecedor { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
    }
}
