using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class TermoAdesao
    {
        public int Codigo { get; set; }
        public int? Usuario { get; set; }
        public int? UsuarioInclusao { get; set; }
        public int? UsuarioAtualizacao { get; set; }
        public int? UsuarioExclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public int CodCurso { get; set; }
        public int CodUsuario { get; set; }

        public virtual Materium CodCursoNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
