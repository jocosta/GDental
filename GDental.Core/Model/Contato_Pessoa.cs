using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Contato_Pessoa
    {
        public int IdContatoCliente { get; set; }        
        public int IdTipoContato { get; set; }
        public int IdPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public string ValorContato { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Tipo_Contato TipoContato { get; set; }
    }
}
