using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class Tipo_ContatoConfig : EntityTypeConfiguration<Tipo_Contato>
    {
        public Tipo_ContatoConfig()
        {
            ToTable("Tipo_Contato");
            HasKey(c => c.IdTipoContato);

            HasRequired(s => s.Empresa)
                   .WithMany(s => s.TipoContatos)
                   .HasForeignKey(s => s.IdEmpresa)
                   .WillCascadeOnDelete(false);
        }
    }
}




