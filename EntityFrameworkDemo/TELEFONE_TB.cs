namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TELEFONE_TB
    {
        [Key]
        public int ID_TELEFONE { get; set; }

        public int ID_PESSOA { get; set; }

        [Required]
        [StringLength(10)]
        public string PREFIXO_TELEFONE { get; set; }

        [Required]
        [StringLength(50)]
        public string NUMERO_TELEFONE { get; set; }

        [StringLength(255)]
        public string OBSERVACAO { get; set; }

        public virtual PESSOA_TB PESSOA_TB { get; set; }
    }
}
