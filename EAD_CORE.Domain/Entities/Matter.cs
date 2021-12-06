﻿using Common;
using EAD_CORE.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_CORE.Domain.Entities
{
    class Matter: CommonServices
    {
        public string descricao { get; set; }
        public string nomeMateria { get; set; }
        public string imagem { get; set; }
        public string hashCodigo { get; set; }
        public IList<FileInputBaseCommon> fileInput { get; set; }
    }
}
