using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CP1_ClassLibrary;


namespace CP1_ClassLibrary.Models
{
    public class Professor : Funcionario
    {
        private String[] disciplinas;

        public Professor (
            string[] disciplinas, 
            string tempoContrato, 
            string cargo, 
            string nome, 
            string cpf
        ) : base(nome, cpf, tempoContrato, cargo)
        {
            this.disciplinas = disciplinas;
        }

        public String[] GetDisciplinas()
        {
            return this.disciplinas;
        }


        public void SetDisciplinas(String[] disciplinas)
        {
            this.disciplinas = disciplinas;
        }

    }
}
