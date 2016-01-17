using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            ToTable("Usuario");
            HasKey(c => c.IdUsuario);

            HasRequired(s => s.Pessoa)
                    .WithMany(s => s.Usuarios)
                    .HasForeignKey(s => s.IdPessoa)
                    .WillCascadeOnDelete(false);

            HasRequired(s => s.Empresa)
                    .WithMany(s => s.Usuarios)
                    .HasForeignKey(s => s.IdEmpresa)
                    .WillCascadeOnDelete(false); ;

            HasRequired(p => p.Funcao)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(p => p.IdFuncao)
                .WillCascadeOnDelete(false); ;
        }
    }
}
