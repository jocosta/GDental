using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public DateTime DataCadastro { get; set; }                
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Pessoa_Documento> PessoaDocumentos { get; set; }
        public virtual ICollection<Contato_Pessoa> ContatoClientes { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
