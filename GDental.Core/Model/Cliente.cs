using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int IdPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        
    }
}
