using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class Perguntum
    {
        public Perguntum()
        {
            Resposta = new HashSet<Resposta>();
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
        public string Pergunta { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public int CodMateria { get; set; }
        public string TipoPergunta { get; set; }

        public virtual Materium CodMateriaNavigation { get; set; }
        public virtual ICollection<Resposta> Resposta { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaResposta> UsuarioMateriaPerguntaResposta { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaRespostasFinal> UsuarioMateriaPerguntaRespostasFinals { get; set; }
    }
}
