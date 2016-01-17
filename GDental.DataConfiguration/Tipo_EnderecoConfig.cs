using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class Tipo_EnderecoConfig : EntityTypeConfiguration<Tipo_Endereco>
    {
        public Tipo_EnderecoConfig()
        {
            ToTable("Tipo_Endereco");

            HasKey(c => c.IdTipoEndereco);

            HasRequired(s => s.Empresa)
                   .WithMany(s => s.TipoEnderecos)
                   .HasForeignKey(s => s.IdEmpresa)
                   .WillCascadeOnDelete(false); 
        }
    }
}

