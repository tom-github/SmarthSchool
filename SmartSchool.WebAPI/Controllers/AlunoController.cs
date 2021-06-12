using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;
using SmartSchool.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository _repo;

        public AlunoController(IRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllAlunos(true);
            return Ok(result);
        }

        // [HttpGet("{id:int}")]
        // [HttpGet("{nome}")]
        // [HttpGet("byName")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repo.GetAlunoById(id,false);
            if (aluno == null) return BadRequest();
            return Ok(aluno);
        }
        
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);

            if(_repo.SaveChanges()){
                return Ok(aluno);
            };

            return BadRequest("Aluno não cadastrado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alunoEncontrado = _repo.GetAlunoById(id);
            if (alunoEncontrado == null) return BadRequest("Aluno não encontrado!");

            _repo.Update(aluno);
            
            if(_repo.SaveChanges()){
                return Ok(aluno);
            };

            return BadRequest("Aluno não atualizado!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
           var alunoEncontrado = _repo.GetAlunoById(id);
            if (alunoEncontrado == null) return BadRequest("Aluno não encontrado!");

            _repo.Update(aluno);
            
            if(_repo.SaveChanges()){
                return Ok(aluno);
            };

            return BadRequest("Aluno não atualizado!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAlunoById(id);
            if (aluno == null) return BadRequest("Aluno não encontrado!");
            
            _repo.Delete(aluno);
            
            if(_repo.SaveChanges()){
                return Ok(aluno);
            };

             return BadRequest("Aluno não Deletado!");
        }
    }
}