using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class Usuario
    {
        public Usuario()
        {
            AulaUsuarioAcessoArquivoLogs = new HashSet<AulaUsuarioAcessoArquivoLog>();
            AulaUsuarioLogs = new HashSet<AulaUsuarioLog>();
            AulaUsuarios = new HashSet<AulaUsuario>();
            Complementos = new HashSet<Complemento>();
            TermoAdesaos = new HashSet<TermoAdesao>();
            UsuarioMateriaPerguntaResposta = new HashSet<UsuarioMateriaPerguntaResposta>();
            UsuarioMateriaPerguntaRespostasFinals = new HashSet<UsuarioMateriaPerguntaRespostasFinal>();
        }

        public int Codigo { get; set; }
        public int? Usuario1 { get; set; }
        public int? UsuarioInclusao { get; set; }
        public int? UsuarioAtualizacao { get; set; }
        public int? UsuarioExclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Observacao { get; set; }
        public int? Tipo { get; set; }
        public string Carteirinha { get; set; }
        public string Chave { get; set; }

        public virtual ICollection<AulaUsuarioAcessoArquivoLog> AulaUsuarioAcessoArquivoLogs { get; set; }
        public virtual ICollection<AulaUsuarioLog> AulaUsuarioLogs { get; set; }
        public virtual ICollection<AulaUsuario> AulaUsuarios { get; set; }
        public virtual ICollection<Complemento> Complementos { get; set; }
        public virtual ICollection<TermoAdesao> TermoAdesaos { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaResposta> UsuarioMateriaPerguntaResposta { get; set; }
        public virtual ICollection<UsuarioMateriaPerguntaRespostasFinal> UsuarioMateriaPerguntaRespostasFinals { get; set; }
    }
}
