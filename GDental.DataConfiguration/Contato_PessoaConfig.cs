using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class Contato_PessoaConfig : EntityTypeConfiguration<Contato_Pessoa>
    {
        public Contato_PessoaConfig()
        {
            ToTable("Contato_Cliente");
            HasKey(c => c.IdContatoCliente);

            HasRequired(s => s.Empresa)
                .WithMany(s => s.ContatoClientes)
                .HasForeignKey(s => s.IdEmpresa).WillCascadeOnDelete(false);

            HasRequired(s => s.TipoContato)
                .WithMany(s => s.ContatoClientes)
                .HasForeignKey(s => s.IdTipoContato).WillCascadeOnDelete(false);

            HasRequired(s => s.Pessoa)
                .WithMany(s => s.ContatoClientes)
                .HasForeignKey(s => s.IdPessoa).WillCascadeOnDelete(false);
        }
    }
}
