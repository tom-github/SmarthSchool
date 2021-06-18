﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.WebAPI.Data;

namespace SmartSchool.WebAPI.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20210618171657_InitMySQL")]
    partial class InitMySQL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(3177),
                            DataNasc = new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(6599),
                            DataNasc = new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(6675),
                            DataNasc = new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(6684),
                            DataNasc = new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(6692),
                            DataNasc = new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(6707),
                            DataNasc = new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(6715),
                            DataNasc = new DateTime(1982, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Nota")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunoCurso");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Nota")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 2, DateTimeKind.Local).AddTicks(9109)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(221)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(254)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(257)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(259)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(266)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(268)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(270)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(272)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(275)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(277)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(279)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(281)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(283)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(285)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(286)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(288)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(291)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(293)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(295)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(297)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(299)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            Inicio = new DateTime(2021, 6, 18, 14, 16, 57, 3, DateTimeKind.Local).AddTicks(301)
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Curso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Nutrição"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Administração"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Mecatrônica"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Biologia"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 4,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 5,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 5,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Registro")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 56, 996, DateTimeKind.Local).AddTicks(1139),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Teste",
                            Telefone = "1111111"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 56, 997, DateTimeKind.Local).AddTicks(7361),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Teste",
                            Telefone = "2222222"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 56, 997, DateTimeKind.Local).AddTicks(7446),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Teste",
                            Telefone = "3333333"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 56, 997, DateTimeKind.Local).AddTicks(7451),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Teste",
                            Telefone = "4444444"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 6, 18, 14, 16, 56, 997, DateTimeKind.Local).AddTicks(7453),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Teste",
                            Telefone = "55555555"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("SmartSchool.WebAPI.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}