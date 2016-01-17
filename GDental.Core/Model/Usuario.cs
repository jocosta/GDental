using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDental.Core.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public int IdFuncao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool FlgAtivo { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Funcao_Usuario Funcao { get; set; }
    }
}
