using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CP1_ClassLibrary;


namespace CP1_ClassLibrary.Models
{
    public class Coordenador : Funcionario
    {
        private String[] cursos;

        public Coordenador(
            string[] cursos,
            string tempoContrato,
            string cargo,
            string nome,
            string cpf
        ) : base(nome, cpf, tempoContrato, cargo)
        {
            this.cursos = cursos;
        }

        public String[] GetCursos()
        {
            return this.cursos;
        }


        public void SetCursos(String[] cursos)
        {
            this.cursos = cursos;
        }

    }
}
