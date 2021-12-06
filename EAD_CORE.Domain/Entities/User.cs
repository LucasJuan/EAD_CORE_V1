using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_CORE.Domain.Entities
{
    public class User : CommonServices
    {

        public string senha { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public DateTime data_nasc { get; set; }
        public string observacao { get; set; }
        public string tipo { get; set; }
        public string carteirinha { get; set; }
        public string Nomeusuario { get; set; }
        public string cargo { get; set; }
        public string EADAdm { get; set; }
        public string chave { get; set; }
        public List<Address> address { get; set; }

    }

}
