using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjetoCinema.Server.Models
{
    public partial class cinemaContext : DbContext
    {
        public cinemaContext()
        {
        }

        public cinemaContext(DbContextOptions<cinemaContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Chefia> Chefia { get; set; }
        public virtual DbSet<Diretor> Diretors { get; set; }
        public virtual DbSet<Filial> Filials { get; set; }
        public virtual DbSet<Filme> Filmes { get; set; }
        public virtual DbSet<Fornecedor> Fornecedors { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<Sessao> Sessaos { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3MH9F1D\\SQLEXPRESS;Database=cinema;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Chefia>(entity =>
            {
                entity.HasKey(e => new { e.CodChefia, e.CodFuncionarioChefe, e.CodFuncionario })
                    .HasName("PK__chefia__2AB5645459050024");

                entity.ToTable("chefia");

                entity.Property(e => e.CodChefia)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cod_chefia");

                entity.Property(e => e.CodFuncionarioChefe).HasColumnName("cod_funcionario_chefe");

                entity.Property(e => e.CodFuncionario).HasColumnName("cod_funcionario");

                entity.HasOne(d => d.CodFuncionarioNavigation)
                    .WithMany(p => p.ChefiumCodFuncionarioNavigations)
                    .HasForeignKey(d => d.CodFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__chefia__cod_func__06CD04F7");

                entity.HasOne(d => d.CodFuncionarioChefeNavigation)
                    .WithMany(p => p.ChefiumCodFuncionarioChefeNavigations)
                    .HasForeignKey(d => d.CodFuncionarioChefe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__chefia__cod_func__05D8E0BE");
            });

            modelBuilder.Entity<Diretor>(entity =>
            {
                entity.HasKey(e => e.CodDiretor)
                    .HasName("PK__diretor__58C86C079BBAE913");

                entity.ToTable("diretor");

                entity.Property(e => e.CodDiretor).HasColumnName("cod_diretor");

                entity.Property(e => e.NomeDiretor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nome_diretor");
            });

            modelBuilder.Entity<Filial>(entity =>
            {
                entity.HasKey(e => e.CodFilial)
                    .HasName("PK__filial__C7E190679B965DD8");

                entity.ToTable("filial");

                entity.Property(e => e.CodFilial).HasColumnName("cod_filial");

                entity.Property(e => e.DescricaoFilial)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descricao_filial");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Filme>(entity =>
            {
                entity.HasKey(e => e.CodFilme)
                    .HasName("PK__filme__86A92E1DC0405F0A");

                entity.ToTable("filme");

                entity.Property(e => e.CodFilme).HasColumnName("cod_filme");

                entity.Property(e => e.CodDiretor).HasColumnName("cod_diretor");

                entity.Property(e => e.CodFornecedor).HasColumnName("cod_fornecedor");

                entity.Property(e => e.CodGenero).HasColumnName("cod_genero");

                entity.Property(e => e.Lancamento)
                    .HasColumnType("date")
                    .HasColumnName("lancamento");

                entity.Property(e => e.TituloFilme)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("titulo_filme");

                entity.HasOne(d => d.CodDiretorNavigation)
                    .WithMany(p => p.Filmes)
                    .HasForeignKey(d => d.CodDiretor)
                    .HasConstraintName("FK__filme__cod_diret__3F466844");

                entity.HasOne(d => d.CodFornecedorNavigation)
                    .WithMany(p => p.Filmes)
                    .HasForeignKey(d => d.CodFornecedor)
                    .HasConstraintName("FK__filme__cod_forne__403A8C7D");

                entity.HasOne(d => d.CodGeneroNavigation)
                    .WithMany(p => p.Filmes)
                    .HasForeignKey(d => d.CodGenero)
                    .HasConstraintName("FK__filme__cod_gener__3E52440B");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.CodFornecedor)
                    .HasName("PK__forneced__CE8B719AAFD54515");

                entity.ToTable("fornecedor");

                entity.Property(e => e.CodFornecedor).HasColumnName("cod_fornecedor");

                entity.Property(e => e.NomeFornecedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome_fornecedor");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.CodFuncionario)
                    .HasName("PK__funciona__304D83924BC0A9CD");

                entity.ToTable("funcionario");

                entity.Property(e => e.CodFuncionario).HasColumnName("cod_funcionario");

                //entity.Property(e => e.Chefia).HasColumnName("chefia");

                entity.Property(e => e.CodFilial).HasColumnName("cod_filial");

                entity.Property(e => e.NomeFuncionario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome_funcionario");

                entity.Property(e => e.SalarioMensal)
                    .HasColumnType("money")
                    .HasColumnName("salario_mensal");

                entity.Property(e => e.Setores)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setores");

                //entity.HasOne(d => d.ChefiaNavigation)
                //    .WithMany(p => p.InverseChefiaNavigation)
                //    .HasForeignKey(d => d.Chefia)
                //    .HasConstraintName("FK__funcionar__chefi__70DDC3D8");

                entity.HasOne(d => d.CodFilialNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.CodFilial)
                    .HasConstraintName("FK__funcionar__cod_f__6FE99F9F");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.CodGenero)
                    .HasName("PK__genero__0DACB9D5DF942E55");

                entity.ToTable("genero");

                entity.Property(e => e.CodGenero).HasColumnName("cod_genero");

                entity.Property(e => e.DescricaoGenero)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descricao_genero");
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.HasKey(e => new { e.CodSala, e.CodFilial })
                    .HasName("PK__sala__37C073DFFBFA2D30");

                entity.ToTable("sala");

                entity.Property(e => e.CodSala)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cod_sala");

                entity.Property(e => e.CodFilial).HasColumnName("cod_filial");

                entity.Property(e => e.DescricaoSala)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descricao_sala");

                entity.HasOne(d => d.CodFilialNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.CodFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sala__cod_filial__4316F928");
            });

            modelBuilder.Entity<Sessao>(entity =>
            {
                entity.HasKey(e => new { e.CodSessao, e.CodFilial })
                    .HasName("PK__sessao__ED4EA96BA65B6EC7");

                entity.ToTable("sessao");

                entity.Property(e => e.CodSessao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cod_sessao");

                entity.Property(e => e.CodFilial).HasColumnName("cod_filial");

                entity.Property(e => e.CodFilme).HasColumnName("cod_filme");

                entity.Property(e => e.CodSala).HasColumnName("cod_sala");

                entity.Property(e => e.DataSessao)
                    .HasColumnType("date")
                    .HasColumnName("data_sessao");

                entity.Property(e => e.HorarioSessao).HasColumnName("horario_sessao");

                entity.Property(e => e.Idioma)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("idioma");

                entity.HasOne(d => d.CodFilialNavigation)
                    .WithMany(p => p.Sessaos)
                    .HasForeignKey(d => d.CodFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sessao__cod_fili__46E78A0C");

                entity.HasOne(d => d.CodFilmeNavigation)
                    .WithMany(p => p.Sessaos)
                    .HasForeignKey(d => d.CodFilme)
                    .HasConstraintName("FK__sessao__cod_film__45F365D3");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.Sessaos)
                    .HasForeignKey(d => new { d.CodSala, d.CodFilial })
                    .HasConstraintName("FK__sessao__47DBAE45");
            });

            modelBuilder.Entity<Venda>(entity =>
            {
                entity.HasKey(e => new { e.CodVenda, e.CodFilial })
                    .HasName("PK__venda__4B4CFBAF3A7B0CDB");

                entity.ToTable("venda");

                entity.Property(e => e.CodVenda)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cod_venda");

                entity.Property(e => e.CodFilial).HasColumnName("cod_filial");

                entity.Property(e => e.CodSessao).HasColumnName("cod_sessao");

                entity.Property(e => e.ValorIngresso)
                    .HasColumnType("money")
                    .HasColumnName("valor_ingresso");

                entity.Property(e => e.DataVenda)
                   .HasColumnType("datetime")
                   .HasColumnName("data_venda");

                entity.HasOne(d => d.CodFilialNavigation)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.CodFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__venda__cod_filia__4AB81AF0");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => new { d.CodSessao, d.CodFilial })
                    .HasConstraintName("FK__venda__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
