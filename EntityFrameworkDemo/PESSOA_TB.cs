namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PESSOA_TB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PESSOA_TB()
        {
            DOCUMENTO_IDENTIFICACAO_TB = new HashSet<DOCUMENTO_IDENTIFICACAO_TB>();
            ENDERECO_TB = new HashSet<ENDERECO_TB>();
            ORDEM_SERVICO_TB = new HashSet<ORDEM_SERVICO_TB>();
            TELEFONE_TB = new HashSet<TELEFONE_TB>();
            USUARIO_TB = new HashSet<USUARIO_TB>();
        }

        [Key]
        public int ID_PESSOA { get; set; }

        public int CODIGO_TIPO_SEXO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_PESSOA { get; set; }

        [StringLength(200)]
        public string SOBRENOME_PESSOA { get; set; }

        [StringLength(100)]
        public string EMAIL_PESSOA { get; set; }

        public DateTime? DATA_NASCIMENTO { get; set; }

        public DateTime DATA_REGISTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTO_IDENTIFICACAO_TB> DOCUMENTO_IDENTIFICACAO_TB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENDERECO_TB> ENDERECO_TB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEM_SERVICO_TB> ORDEM_SERVICO_TB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEFONE_TB> TELEFONE_TB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_TB> USUARIO_TB { get; set; }
    }
}
