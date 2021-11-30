using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tupa.Data
{
    public class Distrito
    {
        public string id { get; set; }
        public Cidade cidade { get; set; }
        public string nome { get; set; }
    }
}
