using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace EAD_CORE.Infra.Context
{
    public partial class PreventivaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public PreventivaContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public PreventivaContext(DbContextOptions<PreventivaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aula> Aulas { get; set; }
        public virtual DbSet<AulaUsuario> AulaUsuarios { get; set; }
        public virtual DbSet<AulaUsuarioAcessoArquivoLog> AulaUsuarioAcessoArquivoLogs { get; set; }
        public virtual DbSet<AulaUsuarioLog> AulaUsuarioLogs { get; set; }
        public virtual DbSet<Complemento> Complementos { get; set; }
        public virtual DbSet<Materium> Materia { get; set; }
        public virtual DbSet<Perguntum> Pergunta { get; set; }
        public virtual DbSet<Resposta> Respostas { get; set; }
        public virtual DbSet<TermoAdesao> TermoAdesaos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioLog> UsuarioLogs { get; set; }
        public virtual DbSet<UsuarioMateriaPerguntaResposta> UsuarioMateriaPerguntaRespostas { get; set; }
        public virtual DbSet<UsuarioMateriaPerguntaRespostasFinal> UsuarioMateriaPerguntaRespostasFinals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetSection("ConnectionString").Value);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Aula>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Aula__40F9A207FBAB913B");

                entity.ToTable("Aula", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Arquivo)
                    .IsUnicode(false)
                    .HasColumnName("arquivo");

                entity.Property(e => e.CodMateria).HasColumnName("codMateria");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Duracao).HasColumnName("duracao");

                entity.Property(e => e.Imagem)
                    .IsUnicode(false)
                    .HasColumnName("imagem");

                entity.Property(e => e.NomeAula)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomeAula");

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.Property(e => e.Video)
                    .IsUnicode(false)
                    .HasColumnName("video");

                entity.HasOne(d => d.CodMateriaNavigation)
                    .WithMany(p => p.Aulas)
                    .HasForeignKey(d => d.CodMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Aula__codMateria__2D27B809");
            });

            modelBuilder.Entity<AulaUsuario>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Aula_Usu__40F9A2070FC2D8AF");

                entity.ToTable("Aula_Usuario", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodAula).HasColumnName("codAula");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.Property(e => e.DataAcessoArquivo)
                    .HasColumnType("datetime")
                    .HasColumnName("data_AcessoArquivo");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inicio");

                entity.Property(e => e.DataUltimoAcesso)
                    .HasColumnType("datetime")
                    .HasColumnName("data_ultimo_acesso");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.HasOne(d => d.CodAulaNavigation)
                    .WithMany(p => p.AulaUsuarios)
                    .HasForeignKey(d => d.CodAula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCodUsuario_aula");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.AulaUsuarios)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Aula_Usua__codUs__30F848ED");
            });

            modelBuilder.Entity<AulaUsuarioAcessoArquivoLog>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Aula_Usu__40F9A207624D6308");

                entity.ToTable("Aula_Usuario_AcessoArquivo_Log", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodAula).HasColumnName("codAula");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.Property(e => e.DataAcessoArquivo)
                    .HasColumnType("datetime")
                    .HasColumnName("data_AcessoArquivo");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.HasOne(d => d.CodAulaNavigation)
                    .WithMany(p => p.AulaUsuarioAcessoArquivoLogs)
                    .HasForeignKey(d => d.CodAula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Aula_Usua__codUs__37A5467C");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.AulaUsuarioAcessoArquivoLogs)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Aula_Usua__codUs__38996AB5");
            });

            modelBuilder.Entity<AulaUsuarioLog>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Aula_Usu__40F9A207874EDDCD");

                entity.ToTable("Aula_Usuario_Log", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodAula).HasColumnName("codAula");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inicio");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.HasOne(d => d.CodAulaNavigation)
                    .WithMany(p => p.AulaUsuarioLogs)
                    .HasForeignKey(d => d.CodAula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Aula_Usua__codUs__33D4B598");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.AulaUsuarioLogs)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Aula_Usua__codUs__34C8D9D1");
            });

            modelBuilder.Entity<Complemento>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Compleme__40F9A2071586D380");

                entity.ToTable("Complemento", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.Property(e => e.Complemento1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("complemento");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("numero");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("referencia");

                entity.Property(e => e.Rua)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rua");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Complementos)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCodUsuario_Complemento");
            });

            modelBuilder.Entity<Materium>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Materia__40F9A207BDF94F2E");

                entity.ToTable("Materia", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Imagem)
                    .IsUnicode(false)
                    .HasColumnName("imagem");

                entity.Property(e => e.NomeMateria)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeMateria");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");
            });

            modelBuilder.Entity<Perguntum>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Pergunta__40F9A207EF2EFFB9");

                entity.ToTable("Pergunta", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodMateria).HasColumnName("codMateria");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Imagem)
                    .IsUnicode(false)
                    .HasColumnName("imagem");

                entity.Property(e => e.Pergunta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pergunta");

                entity.Property(e => e.TipoPergunta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tipoPergunta");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.HasOne(d => d.CodMateriaNavigation)
                    .WithMany(p => p.Pergunta)
                    .HasForeignKey(d => d.CodMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pergunta__tipoPe__3B75D760");
            });

            modelBuilder.Entity<Resposta>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Resposta__40F9A207D7ABA408");

                entity.ToTable("Respostas", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Alternativa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alternativa");

                entity.Property(e => e.CodPergunta).HasColumnName("codPergunta");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.Property(e => e.Verdadeira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("verdadeira");

                entity.HasOne(d => d.CodPerguntaNavigation)
                    .WithMany(p => p.Resposta)
                    .HasForeignKey(d => d.CodPergunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Respostas__codPe__3E52440B");
            });

            modelBuilder.Entity<TermoAdesao>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__TermoAde__40F9A207771762C7");

                entity.ToTable("TermoAdesao", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodCurso).HasColumnName("codCurso");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.HasOne(d => d.CodCursoNavigation)
                    .WithMany(p => p.TermoAdesaos)
                    .HasForeignKey(d => d.CodCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TermoAdes__codCu__4CA06362");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.TermoAdesaos)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TermoAdes__codUs__4D94879B");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Usuario__40F9A207990A0024");

                entity.ToTable("Usuario", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Carteirinha)
                    .IsUnicode(false)
                    .HasColumnName("carteirinha");

                entity.Property(e => e.Chave)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("chave");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.DataNasc)
                    .HasColumnType("date")
                    .HasColumnName("data_nasc");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("observacao");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Usuario1).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");
            });

            modelBuilder.Entity<UsuarioLog>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Usuario___40F9A2079C9E86AB");

                entity.ToTable("Usuario_Log", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Carteirinha)
                    .IsUnicode(false)
                    .HasColumnName("carteirinha");

                entity.Property(e => e.Chave)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("chave");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.DataNasc)
                    .HasColumnType("date")
                    .HasColumnName("data_nasc");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<UsuarioMateriaPerguntaResposta>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Usuario___40F9A207BD404086");

                entity.ToTable("Usuario_Materia_Pergunta_Respostas", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodMateria).HasColumnName("codMateria");

                entity.Property(e => e.CodPergunta).HasColumnName("codPergunta");

                entity.Property(e => e.CodRespostas).HasColumnName("codRespostas");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.HasOne(d => d.CodMateriaNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaResposta)
                    .HasForeignKey(d => d.CodMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codMa__412EB0B6");

                entity.HasOne(d => d.CodPerguntaNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaResposta)
                    .HasForeignKey(d => d.CodPergunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codPe__4222D4EF");

                entity.HasOne(d => d.CodRespostasNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaResposta)
                    .HasForeignKey(d => d.CodRespostas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codRe__4316F928");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaResposta)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codUs__440B1D61");
            });

            modelBuilder.Entity<UsuarioMateriaPerguntaRespostasFinal>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Usuario___40F9A2074C679D1D");

                entity.ToTable("Usuario_Materia_Pergunta_Respostas_Final", "EADPreventiva");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodMateria).HasColumnName("codMateria");

                entity.Property(e => e.CodPergunta).HasColumnName("codPergunta");

                entity.Property(e => e.CodRespostas).HasColumnName("codRespostas");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_atualizacao");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_exclusao");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("data_inclusao");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnName("usuario_atualizacao");

                entity.Property(e => e.UsuarioExclusao).HasColumnName("usuario_exclusao");

                entity.Property(e => e.UsuarioInclusao).HasColumnName("usuario_inclusao");

                entity.HasOne(d => d.CodMateriaNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaRespostasFinals)
                    .HasForeignKey(d => d.CodMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codMa__46E78A0C");

                entity.HasOne(d => d.CodPerguntaNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaRespostasFinals)
                    .HasForeignKey(d => d.CodPergunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codPe__47DBAE45");

                entity.HasOne(d => d.CodRespostasNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaRespostasFinals)
                    .HasForeignKey(d => d.CodRespostas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codRe__48CFD27E");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.UsuarioMateriaPerguntaRespostasFinals)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario_M__codUs__49C3F6B7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
