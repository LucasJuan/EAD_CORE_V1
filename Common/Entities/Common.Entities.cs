using System;


namespace EAD_CORE.Common.Entities
{
    public  class CommonEntities 
    {

        public int Codigo { get; set; }
        public int Usuario { get; set; }
        public int Usuario_inclusao { get; set; }
        public int Usuario_atualizacao { get; set; }
        public int Usuario_exclusao { get; set; }
        public DateTime Data_inclusao { get; set; }
        public DateTime Data_atualizacao { get; set; }
        public DateTime Data_exclusao { get; set; }

       
    }
}
