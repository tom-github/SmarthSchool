using System.Collections.Generic;
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
        private SmartContext _context { get; set; }

        public AlunoController(SmartContext context)
        {
            _context = context;
        }

        // public List<Aluno> Alunos = new List<Aluno>(){
        //     new Aluno(){
        //         Id = 1,
        //         Nome = "Nome1",
        //         Sobrenome = "Sobrenome",
        //         Telefone = "11111111"
        //     },
        //     new Aluno(){
        //         Id = 2,
        //         Nome = "Nome2",
        //         Sobrenome = "Sobrenome2",
        //         Telefone = "22222222"
        //     },
        //     new Aluno(){
        //         Id = 3,
        //         Nome = "Nome3",
        //         Sobrenome = "Sobrenome3",
        //         Telefone = "33333333"
        //     }
        // };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Alunos);
        }

        // [HttpGet("{id:int}")]
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null) return BadRequest();
            return Ok(aluno);
        }

        // [HttpGet("{nome}")]
        [HttpGet("byName")]
        public IActionResult GetById(string nome, string sobrenome)
        {
            var aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Nome.Contains(nome)
                && aluno.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest();
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(aluno => aluno.Id == id);
            if (alunoEncontrado == null) return BadRequest("Aluno não encontrado!");

            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado!");

            _context.Remove(aluno);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(aluno => aluno.Id == id);
            if (alunoEncontrado == null) return BadRequest("Aluno não encontrado!");

            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }
    }
}