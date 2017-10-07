namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENDERECO_TB
    {
        [Key]
        public int ID_ENDERECO { get; set; }

        public int ID_MUNICIPIO { get; set; }

        public int ID_ESTADO { get; set; }

        public int ID_PESSOA { get; set; }

        [Required]
        [StringLength(255)]
        public string LOGRADOURO { get; set; }

        [Required]
        [StringLength(8)]
        public string CEP { get; set; }

        [Required]
        [StringLength(255)]
        public string BAIRRO { get; set; }

        public virtual PESSOA_TB PESSOA_TB { get; set; }
    }
}
