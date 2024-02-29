using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CP1_ClassLibrary;

namespace CP1_ClassLibrary.Models
{
    public class Aluno : Pessoa
    {
        private String Curso;

        public Aluno()
        {
        }

        public Aluno(string Curso, string Nome, string CPF) : base(Nome, CPF)
        {
            this.Curso = Curso;
        }

        public String GetCurso()
        {
            return this.Curso;
        }

        public void SetCurso(String Curso)
        {
            this.Curso = Curso;
        }
    }
}
