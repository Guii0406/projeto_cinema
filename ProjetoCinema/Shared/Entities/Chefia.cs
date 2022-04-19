using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Server.Models
{
    public class Chefia
    {
        public int CodChefia { get; set; }
        public int CodFuncionarioChefe { get; set; }
        public int CodFuncionario { get; set; }

        public virtual Funcionario CodFuncionarioChefeNavigation { get; set; }
        public virtual Funcionario CodFuncionarioNavigation { get; set; }
    }
}
