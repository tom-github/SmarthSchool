using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;
using SmartSchool.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repo;

        public ProfessorController(SmartContext context, IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllProfessores();
            return Ok(result);
        }

        // [HttpGet("{id:int}")]
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetAlunoById(id);
            if (professor == null) return BadRequest();
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            
            if(_repo.SaveChanges()){
                return Ok(professor);
            };

            return BadRequest("Professor não cadastrado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
             var professorEncontrado = _repo.GetAlunoById(id);
            if (professorEncontrado == null) return BadRequest("Professor não encontrado!");

            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var professorEncontrado = _repo.GetAlunoById(id);
            if (professorEncontrado == null) return BadRequest("Professor não encontrado!");

            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repo.GetAlunoById(id);
            if (professor == null) return BadRequest("Professor não encontrado!");

            _repo.Delete(professor);
            _repo.SaveChanges();
            return Ok();
        }
    }
}