using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("Cliente");
            HasKey(c => c.IdCliente);

            HasRequired(s => s.Empresa)
                .WithMany(s => s.Clientes)
                .HasForeignKey(s => s.IdEmpresa).WillCascadeOnDelete(false);

            HasRequired(s => s.Pessoa)
                .WithMany(s => s.Clientes)
                .HasForeignKey(s => s.IdPessoa).WillCascadeOnDelete(false);

        }
    }
    
}
