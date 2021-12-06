using Common;
using EAD_CORE.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_CORE.Domain.Entities
{
    class Lesson : CommonServices
    {
        public string descricao { get; set; }
        public string nomeAula { get; set; }
        public string imagem { get; set; }
        public string video { get; set; }
        public string arquivo { get; set; }
        public int codMateria { get; set; }
        public int codUsuario { get; set; }
        public string nomeMateria { get; set; }
        public int duracao { get; set; }
        public int ordem { get; set; }

        public DateTime? data_inicio { get; set; }
        public DateTime? data_AcessoArquivo { get; set; }
        public DateTime? data_ultimo_acesso { get; set; }
        public IList<FileInputBaseCommon> fileInput { get; set; }
    }

}
