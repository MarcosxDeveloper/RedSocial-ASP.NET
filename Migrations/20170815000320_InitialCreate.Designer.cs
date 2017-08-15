using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProyectoFinal.Models;

namespace ProyectoFinal.Migrations
{
    [DbContext(typeof(AplicacionContext))]
    [Migration("20170815000320_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoFinal.Models.Amigo", b =>
                {
                    b.Property<int>("AmistadID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmigoID");

                    b.Property<int>("Estado");

                    b.Property<int>("UsuarioID");

                    b.HasKey("AmistadID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Amigos");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Comentario", b =>
                {
                    b.Property<int>("ComentarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contenido")
                        .IsRequired();

                    b.Property<DateTime>("Fecha_Comentario");

                    b.Property<int>("PublicacionID");

                    b.Property<int>("UsuarioID");

                    b.HasKey("ComentarioID");

                    b.HasIndex("PublicacionID");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Mensaje", b =>
                {
                    b.Property<int>("MensajeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmigoID");

                    b.Property<string>("Contenido")
                        .IsRequired();

                    b.Property<DateTime>("Fecha_Mensaje");

                    b.Property<int>("UsuarioID");

                    b.HasKey("MensajeID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Mensajes");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Notificacion", b =>
                {
                    b.Property<int>("NotificacionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contenido")
                        .IsRequired();

                    b.Property<int>("UsuarioID");

                    b.HasKey("NotificacionID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Notificaciones");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Perfil", b =>
                {
                    b.Property<int>("PerfilID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Escuela")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Fecha_Nacimiento")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Trabajo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("UsuarioID");

                    b.HasKey("PerfilID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Perfiles");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Publicacion", b =>
                {
                    b.Property<int>("PublicacionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contenido")
                        .IsRequired();

                    b.Property<DateTime>("Fecha_Publicacion");

                    b.Property<int>("UsuarioID");

                    b.HasKey("PublicacionID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Publicaciones");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clave")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<DateTime>("Fecha_Registro");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Amigo", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoFinal.Models.Comentario", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Publicacion", "Publicacion")
                        .WithMany()
                        .HasForeignKey("PublicacionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoFinal.Models.Mensaje", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoFinal.Models.Notificacion", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoFinal.Models.Perfil", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoFinal.Models.Publicacion", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
