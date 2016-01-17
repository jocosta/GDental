using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            ToTable("Endereco");
            HasKey(c => c.IdEnderecoPessoa);

            HasRequired(s => s.Pessoa)
                    .WithMany(s => s.Enderecos)
                    .HasForeignKey(s => s.IdPessoa).WillCascadeOnDelete(false);

            HasRequired(s => s.Empresa)
                    .WithMany(s => s.Enderecos)
                    .HasForeignKey(s => s.IdEmpresa).WillCascadeOnDelete(false); 

            HasRequired(p => p.TipoEndereco)
                .WithMany(p => p.Enderecos)
                .HasForeignKey(p => p.IdTipoEndereco).WillCascadeOnDelete(false);


        }
    }
}
