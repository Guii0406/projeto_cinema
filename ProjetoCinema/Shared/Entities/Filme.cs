using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Filme
    {
        public Filme()
        {
            Sessaos = new HashSet<Sessao>();
        }

        public int CodFilme { get; set; }
        public string TituloFilme { get; set; }
        public DateTime Lancamento { get; set; }
        public int? CodGenero { get; set; }
        public int? CodDiretor { get; set; }
        public int? CodFornecedor { get; set; }

        public virtual Diretor CodDiretorNavigation { get; set; }
        public virtual Fornecedor CodFornecedorNavigation { get; set; }
        public virtual Genero CodGeneroNavigation { get; set; }
        public virtual ICollection<Sessao> Sessaos { get; set; }
    }
}
