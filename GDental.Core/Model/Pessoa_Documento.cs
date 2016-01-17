using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Pessoa_Documento
    {
        public int IdPessoDocumento { get; set; }
        public int IdEmpresa { get; set; }
        public int IdPessoa { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Tipo_Documento TipoDocumento { get; set; }
    }
}
