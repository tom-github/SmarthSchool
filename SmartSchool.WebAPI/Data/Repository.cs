using System.Linq;
using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _context;

        public Repository(SmartContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public Aluno[] GetAllAlunos(bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(aluno => aluno.AlunosDisciplinas)
                             .ThenInclude(alunoDisciplina => alunoDisciplina.Disciplina)
                             .ThenInclude(disciplinaProfessor => disciplinaProfessor.Professor);
            }
            query = query.AsNoTracking().OrderBy(aluno => aluno.Id);

            return query.ToArray();
        }

        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(aluno => aluno.AlunosDisciplinas)
                             .ThenInclude(alunoDisciplina => alunoDisciplina.Disciplina)
                             .ThenInclude(disciplinaProfessor => disciplinaProfessor.Professor);
            }
            query = query.AsNoTracking()
                         .OrderBy(aluno => aluno.Id)
                         .Where(aluno => aluno.AlunosDisciplinas.Any(alunoDisciplina => alunoDisciplina.DisciplinaId == disciplinaId));

            return query.ToArray();
        }

        public Aluno GetAlunoById(int alunoId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(aluno => aluno.AlunosDisciplinas)
                             .ThenInclude(alunoDisciplina => alunoDisciplina.Disciplina)
                             .ThenInclude(disciplinaProfessor => disciplinaProfessor.Professor);
            }
            query = query.AsNoTracking()
                         .OrderBy(aluno => aluno.Id)
                         .Where(aluno => aluno.Id == alunoId);

            return query.FirstOrDefault();
        }

        public Professor[] GetAllProfessores(bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;

            if (includeAlunos)
            {
                query = query.Include(professor => professor.Disciplinas)
                             .ThenInclude(disciplina => disciplina.AlunosDisciplinas)
                             .ThenInclude(alunoDisciplina => alunoDisciplina.Aluno);
            }
            query = query.AsNoTracking().OrderBy(aluno => aluno.Id);

            return query.ToArray();
        }

        public Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;

            if (includeAlunos)
            {
                query = query.Include(disciplina => disciplina.Disciplinas)
                             .ThenInclude(alunoDisciplina => alunoDisciplina.AlunosDisciplinas)
                             .ThenInclude(aluno => aluno.Aluno);
            }
            query = query.AsNoTracking()
                         .OrderBy(aluno => aluno.Id)
                         .Where(aluno => aluno.Disciplinas.Any(
                             disciplina => disciplina.AlunosDisciplinas.Any(alunoDisciplina => alunoDisciplina.DisciplinaId == disciplinaId)));

            return query.ToArray();
        }

        public Professor GetProfessorById(int professorId, bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;

            if (includeAlunos)
            {
                query = query.Include(disciplina => disciplina.Disciplinas)
                              .ThenInclude(alunoDisciplina => alunoDisciplina.AlunosDisciplinas)
                              .ThenInclude(aluno => aluno.Aluno);
            }

            query = query.AsNoTracking()
                         .OrderBy(aluno => aluno.Id)
                         .Where(professor => professor.Id == professorId);

            return query.FirstOrDefault();
        }
    }
}