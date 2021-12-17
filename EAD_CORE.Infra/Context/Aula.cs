using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class Aula
    {
        public Aula()
        {
            AulaUsuarioAcessoArquivoLogs = new HashSet<AulaUsuarioAcessoArquivoLog>();
            AulaUsuarioLogs = new HashSet<AulaUsuarioLog>();
            AulaUsuarios = new HashSet<AulaUsuario>();
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
        public string NomeAula { get; set; }
        public string Imagem { get; set; }
        public string Video { get; set; }
        public string Arquivo { get; set; }
        public int Duracao { get; set; }
        public int CodMateria { get; set; }
        public int? Ordem { get; set; }

        public virtual Materium CodMateriaNavigation { get; set; }
        public virtual ICollection<AulaUsuarioAcessoArquivoLog> AulaUsuarioAcessoArquivoLogs { get; set; }
        public virtual ICollection<AulaUsuarioLog> AulaUsuarioLogs { get; set; }
        public virtual ICollection<AulaUsuario> AulaUsuarios { get; set; }
    }
}
