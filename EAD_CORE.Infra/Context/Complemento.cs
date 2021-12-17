using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class Complemento
    {
        public int Codigo { get; set; }
        public int? Usuario { get; set; }
        public int? UsuarioInclusao { get; set; }
        public int? UsuarioAtualizacao { get; set; }
        public int? UsuarioExclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Referencia { get; set; }
        public string Complemento1 { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public int CodUsuario { get; set; }

        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
