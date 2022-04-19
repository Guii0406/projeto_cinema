using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Venda
    {
        public int CodVenda { get; set; }
        public int CodFilial { get; set; }
        public int? CodSessao { get; set; }
        public decimal ValorIngresso { get; set; }
        public DateTime DataVenda { get; set; }

        public virtual Sessao Cod { get; set; }
        public virtual Filial CodFilialNavigation { get; set; }
    }
}
