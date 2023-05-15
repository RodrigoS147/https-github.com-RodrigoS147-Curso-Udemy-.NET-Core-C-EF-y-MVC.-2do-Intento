using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turnos.Migrations
{
    public partial class Migracion_EntidadTurno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    IdTurno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(unicode: false, nullable: false),
                    IdMedico = table.Column<int>(unicode: false, nullable: false),
                    FechaHoraInicio = table.Column<DateTime>(unicode: false, nullable: false),
                    FechaHoraFin = table.Column<DateTime>(unicode: false, nullable: false),
                    PacienteIdPaciente = table.Column<int>(nullable: true),
                    MedicoIdMedico = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.IdTurno);
                    table.ForeignKey(
                        name: "FK_Turno_Medico_MedicoIdMedico",
                        column: x => x.MedicoIdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Turno_Paciente_PacienteIdPaciente",
                        column: x => x.PacienteIdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turno_MedicoIdMedico",
                table: "Turno",
                column: "MedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_PacienteIdPaciente",
                table: "Turno",
                column: "PacienteIdPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turno");
        }
    }
}
