using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Tipo_Documento
    {
        public int IdTipoDocumento { get; set; }
        public int IdEmpresa { get; set; }
        public string TipoDocumento { get; set; }
        public bool FlgAtivo { get; set; }        
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Pessoa_Documento> PessoaDocumentos { get; set; }
    }
}
