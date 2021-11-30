using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tupa.Data
{
    public class Response<TData>
    {

        public bool succeeded { get; set; }

        public string message { get; set; }

        public List<string> errors { get; set; }

        public TData data { get; set; }
    }


}
