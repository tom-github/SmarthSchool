using System;

namespace SmartSchool.WebAPI.V1.Dtos
{
    /// <summary>
    /// Classe DTO de Alunos
    /// </summary>
    public class AlunoRegistrarDto
    {
        /// <summary>
        /// Identificador �nico do Aluno
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// N�mero de matr�cula
        /// </summary>
        public int Matricula { get; set; }
        /// <summary>
        /// Nome do Aluno
        /// </summary>
        public string Nome { get; set; }
        //Sobrenome do Aluno
        public string Sobrenome { get; set; }
        //Telefone do Aluno
        public string Telefone { get; set; }
        /// <summary>
        /// Data de nascimento do Aluno
        /// </summary>
        public DateTime DataNasc { get; set; }
        /// <summary>
        /// Data de in�cio do contrato Aluno
        /// </summary>
        public DateTime DataInicio { get; set; }
        /// <summary>
        /// Data de fim do contrato do Aluno
        /// </summary>
        public DateTime? DataFim { get; set; }
        /// <summary>
        /// Status do Aluno
        /// </summary>
        public bool Ativo { get; set; } = true;
    }
}