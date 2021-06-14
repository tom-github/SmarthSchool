using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Models;
namespace SmartSchool.WebAPI.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
            .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<AlunoCurso>()
            .HasKey(AC => new { AC.AlunoId, AC.CursoId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, 1, "Lauro","Teste","1111111"),
                    new Professor(2, 2, "Roberto","Teste","2222222"),
                    new Professor(3, 3, "Ronaldo","Teste","3333333"),
                    new Professor(4, 4, "Rodrigo","Teste","4444444"),
                    new Professor(5, 5, "Alexandre","Teste","55555555"),
                });

            builder.Entity<Curso>()
           .HasData(new List<Curso>{
                    new Curso(1, "Sistemas de Informação"),
                    new Curso(2, "Nutrição"),
                    new Curso(3, "Administração"),
                    new Curso(4, "Mecatrônica"),
                    new Curso(5, "Biologia")
           });


            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina(1, "Matemática", 1,2),
                    new Disciplina(2, "Física", 2 ,3),
                    new Disciplina(3, "Português", 3,4),
                    new Disciplina(4, "Inglês", 4,5),
                    new Disciplina(5, "Programação", 5,5)
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1,1, "Marta", "Kent", "33225555", DateTime.Parse("06/12/1982")),
                    new Aluno(2,1, "Paula", "Isabela", "3354288",DateTime.Parse("06/12/1982")),
                    new Aluno(3,1, "Laura", "Antonia", "55668899",DateTime.Parse("06/12/1982")),
                    new Aluno(4,1, "Luiza", "Maria", "6565659",DateTime.Parse("06/12/1982")),
                    new Aluno(5,1, "Lucas", "Machado", "565685415",DateTime.Parse("06/12/1982")),
                    new Aluno(6,1, "Pedro", "Alvares", "456454545",DateTime.Parse("06/12/1982")),
                    new Aluno(7,1, "Paulo", "José", "9874512",DateTime.Parse("06/12/1982"))
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 5 }
                });
        }
    }
}