namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDEM_SERVICO_TB
    {
        [Key]
        public int ID_ORDEM_SERVICO { get; set; }

        public int ID_PESSOA { get; set; }

        public DateTime DATA_REGISTRO { get; set; }

        public DateTime? DATA_FIM_VIGENCIA { get; set; }

        [StringLength(255)]
        public string DESCRICAO_ORDEM_SERVICO { get; set; }

        public decimal VALOR { get; set; }

        public virtual PESSOA_TB PESSOA_TB { get; set; }
    }
}
