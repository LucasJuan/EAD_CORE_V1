using System;


namespace EAD_CORE.Common.Entities
{
    public  class CommonEntities 
    {

        public int codigo { get; set; }
        public int usuario { get; set; }
        public int usuario_inclusao { get; set; }
        public int usuario_atualizacao { get; set; }
        public int usuario_exclusao { get; set; }
        public DateTime data_inclusao { get; set; }
        public DateTime data_atualizacao { get; set; }
        public DateTime data_exclusao { get; set; }

       
    }
}
