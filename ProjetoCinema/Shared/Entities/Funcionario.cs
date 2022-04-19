using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            ChefiumCodFuncionarioChefeNavigations = new HashSet<Chefia>();
            ChefiumCodFuncionarioNavigations = new HashSet<Chefia>();
            //InverseChefiaNavigation = new HashSet<Funcionario>();
        }

        public int CodFuncionario { get; set; }
        public int? CodFilial { get; set; }
        public string NomeFuncionario { get; set; }
        public string Setores { get; set; }
        //public int? Chefia { get; set; }
        public decimal? SalarioMensal { get; set; }

        //public virtual Funcionario ChefiaNavigation { get; set; }
        public virtual Filial CodFilialNavigation { get; set; }
        public virtual ICollection<Chefia> ChefiumCodFuncionarioChefeNavigations { get; set; }
        public virtual ICollection<Chefia> ChefiumCodFuncionarioNavigations { get; set; }
        //public virtual ICollection<Funcionario> InverseChefiaNavigation { get; set; }
    }
}
