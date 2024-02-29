using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CP1_ClassLibrary;


namespace CP1_ClassLibrary.Models
{
    public class Funcionario : Pessoa
    {
        private String tempoContrato;
        private String cargo;

        public Funcionario()
        {
            
        }

        public Funcionario(string tempoContrato, string cargo, string nome, string cpf) : base(nome, cpf)
        {
            this.tempoContrato = tempoContrato;
            this.cargo = cargo;
        }

        public String GetTempoContrato()
        {
            return this.tempoContrato;
        }

        public String GetCargo()
        {
            return this.cargo;
        }

        internal void SetTempoContrato(String tempoContrato)
        {
            this.tempoContrato = tempoContrato;
        }

        private void SetCargo(String cargo)
        {
            this.cargo = cargo;
        }
    }
}
