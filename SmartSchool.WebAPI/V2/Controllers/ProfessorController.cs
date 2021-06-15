using System.Collections;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.Data;
using AutoMapper;
using System.Collections.Generic;
using SmartSchool.WebAPI.V2.Dtos;


namespace SmartSchool.WebAPI.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repo;

        private readonly IMapper _mapper;

        public ProfessorController(SmartContext context, IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // [HttpGet("getRegister")]
        // public IActionResult GetRegister()
        // {
        //     return Ok(new ProfessorRegistrarDto());
        // }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllProfessores();
            return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(result));
        }

        // [HttpGet("{id:int}")]
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetAlunoById(id);
            if (professor == null) return BadRequest();

            var professorDto = _mapper.Map<IEnumerable<ProfessorDto>>(professor);
            return Ok(professorDto);
        }

        [HttpPost]
        public IActionResult Post(ProfessorRegistrarDto model)
        {
            var professor = _mapper.Map<ProfessorDto>(model);

            _repo.Add(professor);

            if (_repo.SaveChanges())
            {
                return Created($"/api/professor/{model.Id}", _mapper.Map<IEnumerable<ProfessorDto>>(professor));
            };

            return BadRequest("Professor não cadastrado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistrarDto model)
        {
            var professor = _repo.GetAlunoById(id);
            if (professor == null) return BadRequest("Professor não encontrado!");

            _mapper.Map(model, professor);

            _repo.Update(professor);

            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<IEnumerable<AlunoDto>>(professor));
            };

            return BadRequest("Prtofessor não atualizado!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistrarDto model)
        {
            var professor = _repo.GetAlunoById(id);
            if (professor == null) return BadRequest("Professor não encontrado!");

            _mapper.Map(model, professor);

            _repo.Update(professor);

            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<IEnumerable<AlunoDto>>(professor));
            };

            return BadRequest("Prtofessor não atualizado!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repo.GetAlunoById(id);
            if (professor == null) return BadRequest("Professor não encontrado!");

            _repo.Delete(professor);

            if (_repo.SaveChanges())
            {
                return Ok(professor);
            };
            return BadRequest("Aluno não Deletado!");
        }
    }
}