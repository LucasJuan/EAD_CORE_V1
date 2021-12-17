using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class UsuarioMateriaPerguntaRespostasFinal
    {
        public int Codigo { get; set; }
        public int? Usuario { get; set; }
        public int? UsuarioInclusao { get; set; }
        public int? UsuarioAtualizacao { get; set; }
        public int? UsuarioExclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public int CodPergunta { get; set; }
        public int CodRespostas { get; set; }
        public int CodMateria { get; set; }
        public int CodUsuario { get; set; }

        public virtual Materium CodMateriaNavigation { get; set; }
        public virtual Perguntum CodPerguntaNavigation { get; set; }
        public virtual Resposta CodRespostasNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
