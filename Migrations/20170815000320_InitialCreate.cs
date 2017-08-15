using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clave = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Fecha_Registro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    AmistadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmigoID = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => x.AmistadID);
                    table.ForeignKey(
                        name: "FK_Amigos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    MensajeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmigoID = table.Column<int>(nullable: false),
                    Contenido = table.Column<string>(nullable: false),
                    Fecha_Mensaje = table.Column<DateTime>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.MensajeID);
                    table.ForeignKey(
                        name: "FK_Mensajes_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    NotificacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contenido = table.Column<string>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.NotificacionID);
                    table.ForeignKey(
                        name: "FK_Notificaciones_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    PerfilID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Direccion = table.Column<string>(maxLength: 20, nullable: false),
                    Escuela = table.Column<string>(maxLength: 20, nullable: false),
                    Fecha_Nacimiento = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    Sexo = table.Column<string>(maxLength: 10, nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Trabajo = table.Column<string>(maxLength: 20, nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.PerfilID);
                    table.ForeignKey(
                        name: "FK_Perfiles_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    PublicacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contenido = table.Column<string>(nullable: false),
                    Fecha_Publicacion = table.Column<DateTime>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.PublicacionID);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    ComentarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contenido = table.Column<string>(nullable: false),
                    Fecha_Comentario = table.Column<DateTime>(nullable: false),
                    PublicacionID = table.Column<int>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.ComentarioID);
                    table.ForeignKey(
                        name: "FK_Comentarios_Publicaciones_PublicacionID",
                        column: x => x.PublicacionID,
                        principalTable: "Publicaciones",
                        principalColumn: "PublicacionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_UsuarioID",
                table: "Amigos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PublicacionID",
                table: "Comentarios",
                column: "PublicacionID");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_UsuarioID",
                table: "Mensajes",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_UsuarioID",
                table: "Notificaciones",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Perfiles_UsuarioID",
                table: "Perfiles",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_UsuarioID",
                table: "Publicaciones",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amigos");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "Perfiles");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
