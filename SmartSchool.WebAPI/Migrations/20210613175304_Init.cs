﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricula = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Registro = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunoCurso",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Fim = table.Column<DateTime>(nullable: true),
                    Nota = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoCurso", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    CargaHoraria = table.Column<int>(nullable: false),
                    PrerequisitoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Disciplinas_PrerequisitoId",
                        column: x => x.PrerequisitoId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Fim = table.Column<DateTime>(nullable: true),
                    Nota = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 1, true, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(802), new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Marta", "Kent", "33225555" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 2, true, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(3826), new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Paula", "Isabela", "3354288" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 3, true, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(3901), new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Laura", "Antonia", "55668899" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 4, true, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(3911), new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Luiza", "Maria", "6565659" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 5, true, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(3920), new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lucas", "Machado", "565685415" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 6, true, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(3935), new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pedro", "Alvares", "456454545" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 7, true, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(3943), new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Paulo", "José", "9874512" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "Biologia" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "Mecatrônica" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Nutrição" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Sistemas de Informação" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Administração" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 4, true, null, new DateTime(2021, 6, 13, 14, 53, 3, 996, DateTimeKind.Local).AddTicks(5159), "Rodrigo", 4, "Teste", "4444444" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 1, true, null, new DateTime(2021, 6, 13, 14, 53, 3, 994, DateTimeKind.Local).AddTicks(7272), "Lauro", 1, "Teste", "1111111" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 2, true, null, new DateTime(2021, 6, 13, 14, 53, 3, 996, DateTimeKind.Local).AddTicks(5082), "Roberto", 2, "Teste", "2222222" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 3, true, null, new DateTime(2021, 6, 13, 14, 53, 3, 996, DateTimeKind.Local).AddTicks(5155), "Ronaldo", 3, "Teste", "3333333" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 5, true, null, new DateTime(2021, 6, 13, 14, 53, 3, 996, DateTimeKind.Local).AddTicks(5161), "Alexandre", 5, "Teste", "55555555" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 1, 0, 2, "Matemática", null, 1 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 2, 0, 3, "Física", null, 2 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 3, 0, 4, "Português", null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 4, 0, 5, "Inglês", null, 4 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 5, 0, 5, "Programação", null, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 2, 1, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6625), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 4, 5, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6645), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 2, 5, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6633), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 1, 5, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6622), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 7, 4, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6665), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 6, 4, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6658), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 5, 4, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6647), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 4, 4, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6644), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 1, 4, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6593), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 7, 3, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6663), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 5, 5, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6649), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 6, 3, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6655), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 7, 2, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6661), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 6, 2, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6653), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 3, 2, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6636), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 2, 2, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6627), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 1, 2, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(5626), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 7, 1, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6660), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 6, 1, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6651), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 4, 1, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6642), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 3, 1, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6635), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 3, 3, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6638), null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "Fim", "Inicio", "Nota" },
                values: new object[] { 7, 5, null, new DateTime(2021, 6, 13, 14, 53, 4, 1, DateTimeKind.Local).AddTicks(6667), null });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoCurso_CursoId",
                table: "AlunoCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PrerequisitoId",
                table: "Disciplinas",
                column: "PrerequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoCurso");

            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
