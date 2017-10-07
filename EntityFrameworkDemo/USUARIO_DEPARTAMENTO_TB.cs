namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USUARIO_DEPARTAMENTO_TB
    {
        [Key]
        public int ID_USUARIO_DEPARTAMENTO { get; set; }

        public int ID_USUARIO_FUNCAO { get; set; }

        public int ID_USUARIO_SETOR { get; set; }

        public int ID_USUARIO { get; set; }

        public virtual USUARIO_TB USUARIO_TB { get; set; }
    }
}
