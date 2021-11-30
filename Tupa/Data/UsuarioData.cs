using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tupa.Data
{
    public class UsuarioData
    {

        public string userId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public bool emailConfirmed { get; set; }
        public string tipoUsuario { get; set; }
    }
}
