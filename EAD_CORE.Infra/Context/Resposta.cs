using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class Resposta
    {
        public Resposta()
        {
            UsuarioMateriaPerguntaResposta = new HashSet<UsuarioMateriaPerguntaResposta>();
            UsuarioMateriaPerguntaRespostasFinals = new HashSet<UsuarioMateriaPerguntaRespostasFinal>();
        }

        public int Codigo { get; set; }
        public int? Usuario { get; set; }
        public int? UsuarioInclusao { get; set; }
        public int? UsuarioAtualizacao { get; set; }
        public int? UsuarioExclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public string Alternativa { get; set; }
        public string Verdadeira { get; set; }
        public int CodPergunta { get; set; }

        public virtual Perguntum CodPerguntaNavigation { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaResposta> UsuarioMateriaPerguntaResposta { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaRespostasFinal> UsuarioMateriaPerguntaRespostasFinals { get; set; }
    }
}
