using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthContext.Services
{
    public partial class Access
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string key { get; set; }
        public string ativo { get; set; }
        public string role { get; set; }
    }
}
