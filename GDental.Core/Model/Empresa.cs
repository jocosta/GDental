using System.Collections.Generic;
using System.ComponentModel;

namespace GDental.Core.Model
{
    public class Empresa
    {
        
        public int IdEmpresa { get; set; }
        [DisplayName("CRO Responsavel")]
        public string CroResponsavel { get; set; }
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("Inicio Expediente")]
        public string InicioExpediente { get; set; }
        [DisplayName("Fim Expediente")]
        public string FimExpediente { get; set; }
        [DisplayName("Chave Api")]
        public string ChaveApi { get; set; }

        public virtual ICollection<Tipo_Endereco> TipoEnderecos { get; set; }
        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Tipo_Contato> TipoContatos { get; set; }
        public virtual ICollection<Tipo_Documento> TipoDocumentos { get; set; }
        public virtual ICollection<Pessoa_Documento> PessoaDocumentos { get; set; }
        public virtual ICollection<Funcao_Usuario> FuncaoUsuarios { get; set; }
        public virtual ICollection<Contato_Pessoa> ContatoClientes { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        
    }
}
