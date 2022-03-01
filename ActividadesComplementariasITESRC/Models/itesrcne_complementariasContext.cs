using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class itesrcne_complementariasContext : DbContext
    {
        public itesrcne_complementariasContext()
        {
        }

        public itesrcne_complementariasContext(DbContextOptions<itesrcne_complementariasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividadescomplementarias> Actividadescomplementarias { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoGrupos> AlumnoGrupos { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Criterio> Criterio { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Evaluacionalumno> Evaluacionalumno { get; set; }
        public virtual DbSet<EvaluacionalumnoCriterios> EvaluacionalumnoCriterios { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Responsables> Responsables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=204.93.216.11;user=itesrcne_proy22;password=4veSZ42@Eii4SMt;database=itesrcne_complementarias", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.29-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8");

            modelBuilder.Entity<Actividadescomplementarias>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdDepartamento })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("actividadescomplementarias");

                entity.HasIndex(e => e.IdDepartamento, "fk_ActividadesComplementarias_Departamento_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdDepartamento)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Departamento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Horas).HasColumnType("int(2)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Actividadescomplementarias)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ActividadesComplementarias_Departamento");
            });

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdCarrera })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("alumno");

                entity.HasIndex(e => e.IdCarrera, "fk_Alumno_Carrera1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCarrera)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Carrera");

                entity.Property(e => e.Eliminando).HasColumnType("bit(1)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NumeroControl)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Alumno_Carrera1");
            });

            modelBuilder.Entity<AlumnoGrupos>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdAlumno, e.IdGrupos })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("alumno_grupos");

                entity.HasIndex(e => e.IdAlumno, "fk_Alumno_Grupos_Alumno1_idx");

                entity.HasIndex(e => e.IdGrupos, "fk_Alumno_Grupos_Grupos1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdAlumno)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Alumno");

                entity.Property(e => e.IdGrupos)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Grupos");

                entity.Property(e => e.Eliminado).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.ToTable("carrera");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Eliminado).HasColumnType("tinyint(4)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Criterio>(entity =>
            {
                entity.ToTable("criterio");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Eliminado).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("departamento");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Eliminando).HasColumnType("tinyint(4)");

                entity.Property(e => e.Jefe)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Evaluacionalumno>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdGrupos })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("evaluacionalumno");

                entity.HasIndex(e => e.IdGrupos, "fk_EvaluacionAlumno_Grupos1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdGrupos)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Grupos");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EvaluacionalumnoCriterios>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdEvaluacionAlumno, e.IdCriterio })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("evaluacionalumno_criterios");

                entity.HasIndex(e => e.IdCriterio, "fk_EvaluacionAlumno_Criterios_Criterio1_idx");

                entity.HasIndex(e => e.IdEvaluacionAlumno, "fk_EvaluacionAlumno_Criterios_EvaluacionAlumno1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdEvaluacionAlumno)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_EvaluacionAlumno");

                entity.Property(e => e.IdCriterio)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Criterio");

                entity.HasOne(d => d.IdCriterioNavigation)
                    .WithMany(p => p.EvaluacionalumnoCriterios)
                    .HasForeignKey(d => d.IdCriterio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EvaluacionAlumno_Criterios_Criterio1");
            });

            modelBuilder.Entity<Grupos>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdActividadesComplementarias, e.IdResponsables, e.IdAlumno })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("grupos");

                entity.HasIndex(e => e.IdActividadesComplementarias, "fk_Grupos_ActividadesComplementarias1_idx");

                entity.HasIndex(e => e.IdAlumno, "fk_Grupos_Alumno1_idx");

                entity.HasIndex(e => e.IdResponsables, "fk_Grupos_Responsables1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdActividadesComplementarias)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_ActividadesComplementarias");

                entity.Property(e => e.IdResponsables)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Responsables");

                entity.Property(e => e.IdAlumno)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Alumno");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdResponsablesNavigation)
                    .WithMany(p => p.Grupos)
                    .HasForeignKey(d => d.IdResponsables)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Grupos_Responsables1");
            });

            modelBuilder.Entity<Responsables>(entity =>
            {
                entity.ToTable("responsables");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Eliminando).HasColumnType("tinyint(4)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
