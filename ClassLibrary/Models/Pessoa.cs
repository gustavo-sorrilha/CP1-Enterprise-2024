using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CP1_ClassLibrary;


namespace CP1_ClassLibrary.Models
{
    public class Pessoa
    {
        private String nome;
        private String cpf;

        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public Pessoa() : this("Gustavo", "123") {  }

        public String GetNome() { 
            return this.nome;
        }

        public String GetCPF() { 
            return this.cpf; 
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        protected void SetCPF(String cpf)
        {
            this.cpf = cpf;
        }
    }
}
