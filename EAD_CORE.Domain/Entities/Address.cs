using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_CORE.Domain.Entities
{
    public class Address
    {
        public string cidade { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string referencia { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public int codUsuario { get; set; }
    }
}
