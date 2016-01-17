using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class Tipo_DocumentoConfig : EntityTypeConfiguration<Tipo_Documento>
    {
        public Tipo_DocumentoConfig()
        {
            ToTable("Tipo_Documento");
            HasKey(c => c.IdTipoDocumento);

            HasRequired(s => s.Empresa)
                .WithMany(s => s.TipoDocumentos)
                .HasForeignKey(s => s.IdEmpresa)
                .WillCascadeOnDelete(false);
        }
    }
}




