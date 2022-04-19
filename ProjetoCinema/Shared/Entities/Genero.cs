using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Filmes = new HashSet<Filme>();
        }

        public int CodGenero { get; set; }
        public string DescricaoGenero { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
    }
}
