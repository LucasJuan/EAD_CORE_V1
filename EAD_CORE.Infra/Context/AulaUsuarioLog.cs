using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class AulaUsuarioLog
    {
        public int Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public DateTime? DataInicio { get; set; }
        public string Descricao { get; set; }
        public int CodAula { get; set; }
        public int CodUsuario { get; set; }

        public virtual Aula CodAulaNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
