using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFdesafioArquivo
{
    internal class Curso
    {
        public string CodigoCurso { get; set; }
        public string NomeCurso { get; set; }

        public Curso(string codigoCurso, string nomeCurso)
        {
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }
    }
}
