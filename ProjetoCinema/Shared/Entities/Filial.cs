using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Filial
    {
        public Filial()
        {
            Funcionarios = new HashSet<Funcionario>();
            Salas = new HashSet<Sala>();
            Sessaos = new HashSet<Sessao>();
            Venda = new HashSet<Venda>();
        }

        public int CodFilial { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string DescricaoFilial { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Sala> Salas { get; set; }
        public virtual ICollection<Sessao> Sessaos { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
