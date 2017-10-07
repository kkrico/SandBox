namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USUARIO_TB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO_TB()
        {
            USUARIO_DEPARTAMENTO_TB = new HashSet<USUARIO_DEPARTAMENTO_TB>();
        }

        [Key]
        public int ID_USUARIO { get; set; }

        public int ID_PESSOA { get; set; }

        public int CODIGO_TIPO_USUARIO { get; set; }

        public bool DESATIVADO { get; set; }

        [StringLength(255)]
        public string DESCRICAO_DESATIVACAO { get; set; }

        [Required]
        [StringLength(40)]
        public string SENHA { get; set; }

        public bool ALTERACAO_SENHA { get; set; }

        public virtual PESSOA_TB PESSOA_TB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_DEPARTAMENTO_TB> USUARIO_DEPARTAMENTO_TB { get; set; }
    }
}
