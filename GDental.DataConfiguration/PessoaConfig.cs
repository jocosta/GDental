using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            ToTable("Pessoa");
            HasKey(c => c.IdPessoa);
            
            HasRequired(s => s.Empresa)
                    .WithMany(s => s.Pessoas)
                    .HasForeignKey(s => s.IdEmpresa)
                    .WillCascadeOnDelete(false);
        }
    }
}
