using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace jojo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bibliotecario",
                columns: table => new
                {
                    id_bib = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    contraseña = table.Column<string>(nullable: false),
                    usuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bibliotecario", x => x.id_bib);
                });

            migrationBuilder.CreateTable(
                name: "estudiante",
                columns: table => new
                {
                    cod_est = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ape = table.Column<string>(nullable: true),
                    contraseña = table.Column<string>(nullable: false),
                    escuela = table.Column<string>(nullable: true),
                    nomb = table.Column<string>(nullable: true),
                    usuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estudiante", x => x.cod_est);
                });

            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    cod_lib = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CD = table.Column<bool>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    alto = table.Column<double>(nullable: false),
                    ancho = table.Column<double>(nullable: false),
                    autor = table.Column<string>(nullable: false),
                    año_pub = table.Column<int>(nullable: false),
                    cantidad_hoj = table.Column<int>(nullable: false),
                    cantidad_lib = table.Column<int>(nullable: false),
                    categoria = table.Column<string>(nullable: false),
                    editorial = table.Column<string>(nullable: false),
                    estado_libro = table.Column<string>(nullable: true),
                    idioma = table.Column<string>(nullable: false),
                    portada = table.Column<byte>(nullable: true),
                    sipnosis = table.Column<string>(nullable: false),
                    titulo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.cod_lib);
                });

            migrationBuilder.CreateTable(
                name: "prestamo",
                columns: table => new
                {
                    cod_prest = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    cod_lib = table.Column<int>(nullable: false),
                    datosEstudiantecod_est = table.Column<int>(nullable: true),
                    fecha_reserva = table.Column<DateTime>(nullable: false),
                    modalidad = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamo", x => x.cod_prest);
                    table.ForeignKey(
                        name: "FK_prestamo_libros_cod_lib",
                        column: x => x.cod_lib,
                        principalTable: "libros",
                        principalColumn: "cod_lib",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prestamo_estudiante_datosEstudiantecod_est",
                        column: x => x.datosEstudiantecod_est,
                        principalTable: "estudiante",
                        principalColumn: "cod_est",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reserva",
                columns: table => new
                {
                    cod_res = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    cod_prest = table.Column<int>(nullable: false),
                    estado_reserva = table.Column<string>(nullable: true),
                    fecha_realizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserva", x => x.cod_res);
                    table.ForeignKey(
                        name: "FK_reserva_prestamo_cod_prest",
                        column: x => x.cod_prest,
                        principalTable: "prestamo",
                        principalColumn: "cod_prest",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_prestamo_cod_lib",
                table: "prestamo",
                column: "cod_lib");

            migrationBuilder.CreateIndex(
                name: "IX_prestamo_datosEstudiantecod_est",
                table: "prestamo",
                column: "datosEstudiantecod_est");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_cod_prest",
                table: "reserva",
                column: "cod_prest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bibliotecario");

            migrationBuilder.DropTable(
                name: "reserva");

            migrationBuilder.DropTable(
                name: "prestamo");

            migrationBuilder.DropTable(
                name: "libros");

            migrationBuilder.DropTable(
                name: "estudiante");
        }
    }
}
