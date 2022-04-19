using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Sala
    {
        public Sala()
        {
            Sessaos = new HashSet<Sessao>();
        }

        public int CodSala { get; set; }
        public int CodFilial { get; set; }
        public string DescricaoSala { get; set; }

        public virtual Filial CodFilialNavigation { get; set; }
        public virtual ICollection<Sessao> Sessaos { get; set; }
    }
}
