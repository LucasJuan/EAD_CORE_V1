using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class Materium
    {
        public Materium()
        {
            Aulas = new HashSet<Aula>();
            Pergunta = new HashSet<Perguntum>();
            TermoAdesaos = new HashSet<TermoAdesao>();
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
        public string Descricao { get; set; }
        public string NomeMateria { get; set; }
        public string Imagem { get; set; }

        public virtual ICollection<Aula> Aulas { get; set; }
        public virtual ICollection<Perguntum> Pergunta { get; set; }
        public virtual ICollection<TermoAdesao> TermoAdesaos { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaResposta> UsuarioMateriaPerguntaResposta { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaRespostasFinal> UsuarioMateriaPerguntaRespostasFinals { get; set; }
    }
}
