using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Funcao_Usuario
    {
        public int IdFuncaoUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public string Descricao { get; set; }        
        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set;}
    }
}
