using System.Collections.Generic;

namespace GDental.Core.Model
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string CroResponsavel { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InicioExpediente { get; set; }
        public string FimExpediente { get; set; }
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
