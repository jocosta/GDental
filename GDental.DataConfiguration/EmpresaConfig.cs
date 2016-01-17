using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace GDental.DataConfiguration
{
    public class EmpresaConfig : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfig()
        {
            ToTable("Empresa");
            HasKey(c => c.IdEmpresa);
            Property(c => c.IdEmpresa).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
