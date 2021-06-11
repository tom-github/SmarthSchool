using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Nome1",
                Sobrenome = "Sobrenome",
                Telefone = "11111111"
            },
            new Aluno(){
                Id = 2,
                Nome = "Nome2",
                Sobrenome = "Sobrenome2",
                Telefone = "22222222"
            },
            new Aluno(){
                Id = 3,
                Nome = "Nome3",
                Sobrenome = "Sobrenome3",
                Telefone = "33333333"
            }
        };
        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        // [HttpGet("{id:int}")]
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null) return BadRequest();
            return Ok(aluno);
        }

        // [HttpGet("{nome}")]
        [HttpGet("byName")]
        public IActionResult GetById(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(aluno => aluno.Nome.Contains(nome)
                && aluno.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest();
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok();
        }
    }
}