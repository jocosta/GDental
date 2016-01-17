using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Endereco
    {
        public int IdEnderecoPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public int IdPessoa { get; set; }
        public int IdTipoEndereco{ get; set; }
        public string Lagradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Tipo_Endereco TipoEndereco { get; set; }
    }
}
