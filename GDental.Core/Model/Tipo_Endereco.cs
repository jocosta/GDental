using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Tipo_Endereco
    {
        public int IdTipoEndereco { get; set; }
        public int IdEmpresa { get; set; }
        public string TipoEndereco { get; set; }
        public bool FlgAtivo { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
