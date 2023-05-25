using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFdesafioArquivo
{
    internal class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public Curso Curso { get; set; }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, Curso curso) : base(nome, telefone, cidade, rg, cpf)
        {
            Matricula = matricula;
            Curso = curso;
        }
    }
}
