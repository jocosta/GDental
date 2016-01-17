using System.Data.Entity.ModelConfiguration;
using GDental.Core.Model;

namespace GDental.DataConfiguration
{
    public class Funcao_UsuarioConfig : EntityTypeConfiguration<Funcao_Usuario>
    {
        public Funcao_UsuarioConfig()
        {
            ToTable("Funcao_Usuario");
            HasKey(c => c.IdFuncaoUsuario);

            HasRequired(s => s.Empresa)
                .WithMany(s => s.FuncaoUsuarios)
                .HasForeignKey(s => s.IdEmpresa).WillCascadeOnDelete(false);
        }
    }
}
