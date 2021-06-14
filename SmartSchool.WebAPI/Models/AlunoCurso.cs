using System;

namespace SmartSchool.WebAPI.Models
{
    public class AlunoCurso
    {
        public AlunoCurso(){}
        public AlunoCurso(int alunoId, int cursoId, Aluno aluno, Curso curso)
        {
            this.AlunoId = alunoId;
            this.CursoId = cursoId;
        }

        public DateTime Inicio { get; set; } = DateTime.Now;
        public DateTime? Fim { get; set; } = null;

        public int? Nota { get; set; }
        public int AlunoId { get; set; }
        public int CursoId { get; set; }
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
    }
}
