namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DOCUMENTO_IDENTIFICACAO_TB
    {
        [Key]
        public int ID_DOCUMENTO_IDENTIFICACAO { get; set; }

        public int ID_PESSOA { get; set; }

        public int CODIGO_TIPO_DOCUMENTO_IDENTIFICACAO { get; set; }

        [Required]
        [StringLength(11)]
        public string NUMERO_DOCUMENTO_IDENTIFICACAO { get; set; }

        public virtual PESSOA_TB PESSOA_TB { get; set; }
    }
}
