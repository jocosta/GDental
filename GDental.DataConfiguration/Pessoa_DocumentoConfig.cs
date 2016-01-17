using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class Pessoa_DocumentoConfig : EntityTypeConfiguration<Pessoa_Documento>
    {
        public Pessoa_DocumentoConfig()
        {
            ToTable("Pessoa_Documento");
            HasKey(c => c.IdPessoDocumento);

            HasRequired(s => s.Empresa)
                .WithMany(s => s.PessoaDocumentos)
                .HasForeignKey(s => s.IdEmpresa).WillCascadeOnDelete(false);

            HasRequired(s => s.Pessoa)
                .WithMany(s => s.PessoaDocumentos)
                .HasForeignKey(s => s.IdPessoa).WillCascadeOnDelete(false);

            HasRequired(s => s.TipoDocumento)
                .WithMany(s => s.PessoaDocumentos)
                .HasForeignKey(s => s.IdTipoDocumento).WillCascadeOnDelete(false);

        }
    }
}

