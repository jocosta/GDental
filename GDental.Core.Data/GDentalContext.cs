using GDental.Core.Model;
using GDental.DataConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Data
{
    public class GDentalContext : DbContext
    {
        public GDentalContext()
            :base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<GDentalContext>());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato_Pessoa> ContatoPessoas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcao_Usuario> FuncaoUsuario { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Pessoa_Documento> PessoaDocumento { get; set; }
        public DbSet<Tipo_Contato> TipoContatos { get; set; }
        public DbSet<Tipo_Documento> TipoDocumentos { get; set; }
        public DbSet<Tipo_Endereco> TipoEnderecos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new Contato_PessoaConfig());
            modelBuilder.Configurations.Add(new EmpresaConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new Funcao_UsuarioConfig());
            modelBuilder.Configurations.Add(new Pessoa_DocumentoConfig());
            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new Tipo_ContatoConfig());
            modelBuilder.Configurations.Add(new Tipo_DocumentoConfig());
            modelBuilder.Configurations.Add(new Tipo_EnderecoConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());


            base.OnModelCreating(modelBuilder);
        }
    }
}
