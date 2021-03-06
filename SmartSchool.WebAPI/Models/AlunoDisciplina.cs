using System;

namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina(){}
        public AlunoDisciplina(int alunoId, int disciplinaId, Aluno aluno, Disciplina disciplina)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaId;
        }

        public DateTime Inicio { get; set; } = DateTime.Now;
        public DateTime? Fim { get; set; } = null;

        public int? Nota { get; set; }
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
