namespace EntityFrameworkDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityFrameworkDemoContext : DbContext
    {
        public EntityFrameworkDemoContext()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<DOCUMENTO_IDENTIFICACAO_TB> DOCUMENTO_IDENTIFICACAO_TB { get; set; }
        public virtual DbSet<ENDERECO_TB> ENDERECO_TB { get; set; }
        public virtual DbSet<ORDEM_SERVICO_TB> ORDEM_SERVICO_TB { get; set; }
        public virtual DbSet<PESSOA_TB> PESSOA_TB { get; set; }
        public virtual DbSet<TELEFONE_TB> TELEFONE_TB { get; set; }
        public virtual DbSet<USUARIO_DEPARTAMENTO_TB> USUARIO_DEPARTAMENTO_TB { get; set; }
        public virtual DbSet<USUARIO_TB> USUARIO_TB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DOCUMENTO_IDENTIFICACAO_TB>()
                .Property(e => e.NUMERO_DOCUMENTO_IDENTIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_TB>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_TB>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_TB>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEM_SERVICO_TB>()
                .Property(e => e.DESCRICAO_ORDEM_SERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEM_SERVICO_TB>()
                .Property(e => e.VALOR)
                .HasPrecision(15, 0);

            modelBuilder.Entity<PESSOA_TB>()
                .Property(e => e.NOME_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_TB>()
                .Property(e => e.SOBRENOME_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_TB>()
                .Property(e => e.EMAIL_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_TB>()
                .HasMany(e => e.DOCUMENTO_IDENTIFICACAO_TB)
                .WithRequired(e => e.PESSOA_TB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA_TB>()
                .HasMany(e => e.ENDERECO_TB)
                .WithRequired(e => e.PESSOA_TB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA_TB>()
                .HasMany(e => e.ORDEM_SERVICO_TB)
                .WithRequired(e => e.PESSOA_TB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA_TB>()
                .HasMany(e => e.TELEFONE_TB)
                .WithRequired(e => e.PESSOA_TB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA_TB>()
                .HasMany(e => e.USUARIO_TB)
                .WithRequired(e => e.PESSOA_TB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TELEFONE_TB>()
                .Property(e => e.PREFIXO_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TELEFONE_TB>()
                .Property(e => e.NUMERO_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TELEFONE_TB>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO_TB>()
                .Property(e => e.DESCRICAO_DESATIVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO_TB>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO_TB>()
                .HasMany(e => e.USUARIO_DEPARTAMENTO_TB)
                .WithRequired(e => e.USUARIO_TB)
                .WillCascadeOnDelete(false);
        }
    }
}
