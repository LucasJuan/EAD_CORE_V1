using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class UsuarioLog
    {
        public int Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public int? Tipo { get; set; }
        public string Carteirinha { get; set; }
        public string Chave { get; set; }
    }
}
