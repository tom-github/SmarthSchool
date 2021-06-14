using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.Dtos;
using AutoMapper;

namespace SmartSchool.WebAPI.Helpers
{
    public class SmartSchoolProfile : Profile
    {
        public SmartSchoolProfile()
        {
            CreateMap<Aluno, AlunoDto>()
            .ForMember(destino => destino.Nome,
            opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}")
            )
            .ForMember(destino => destino.Idade,
            opt => opt.MapFrom(src => src.DataNasc.GetCurrentAge())
            );

            CreateMap<AlunoDto, Aluno>();
            CreateMap<Aluno,AlunoRegistrarDto>().ReverseMap();


            CreateMap<Professor, ProfessorDto>()
            .ForMember(destino => destino.Nome,
            opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}")
            );

            CreateMap<ProfessorDto, Professor>();
            CreateMap<Professor,ProfessorRegistrarDto>().ReverseMap();
        }

    }
}