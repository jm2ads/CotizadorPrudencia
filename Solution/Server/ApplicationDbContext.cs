using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Project.Shared.Models;


namespace Project.Server
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public  DbSet<Admin> Admins { get; set; }
        public DbSet<ZirenHead> ZirenHead { get; set; }
        public  DbSet<Grupo> Grupos { get; set; }
        public  DbSet<Organizador> Organizadores { get; set; }
        public  DbSet<Productor> Productores { get; set; }
        public  DbSet<Vendedor> Vendedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.AdminNombre);

                entity.ToTable("Admin");

                entity.Property(e => e.AdminNombre).HasMaxLength(50);

                entity.Property(e => e.AdminPassWord)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZirenHead>(entity =>
            {
                entity.ToTable("ZirenHead");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular1)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Celular2).HasMaxLength(15);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DNI");

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GncMonto).HasColumnName("GNC_Monto");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasMaxLength(50);

            

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Whatsapp).HasMaxLength(100);
            });



            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.ToTable("Grupo");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular1)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Celular2).HasMaxLength(15);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DNI");

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GncMonto).HasColumnName("GNC_Monto");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasMaxLength(50);

             

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Whatsapp).HasMaxLength(100);
            });

            modelBuilder.Entity<Organizador>(entity =>
            {
                entity.ToTable("Organizador");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular1)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Celular2).HasMaxLength(15);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DNI");

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GncMonto).HasColumnName("GNC_Monto");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasMaxLength(50);

              

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Whatsapp).HasMaxLength(100);

              
            });

            modelBuilder.Entity<Productor>(entity =>
            {
                entity.ToTable("Productor");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular1)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Celular2).HasMaxLength(15);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DNI");

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GncMonto).HasColumnName("GNC_Monto");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasMaxLength(50);

             

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Whatsapp).HasMaxLength(100);

               
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.ToTable("Vendedor");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular1)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Celular2).HasMaxLength(15);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DNI");

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GncMonto).HasColumnName("GNC_Monto");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasMaxLength(50);

               

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Whatsapp).HasMaxLength(100);

              
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
