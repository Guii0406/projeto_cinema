using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Sessao
    {
        public Sessao()
        {
            Venda = new HashSet<Venda>();
        }

        public int CodSessao { get; set; }
        public int? CodFilme { get; set; }
        public int CodFilial { get; set; }
        public int? CodSala { get; set; }
        public TimeSpan HorarioSessao { get; set; }
        public DateTime DataSessao { get; set; }
        public string Idioma { get; set; }

        public virtual Sala Cod { get; set; }
        public virtual Filial CodFilialNavigation { get; set; }
        public virtual Filme CodFilmeNavigation { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
