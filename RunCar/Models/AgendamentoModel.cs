using System;
using System.Collections.Generic;
using System.Text;

namespace RunCar.Models
{
   public class AgendamentoModel
    {

        public Veiculo veiculo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        DateTime dataAgendamento = DateTime.Today;
        TimeSpan horaAgendamento;
        public DateTime DataAgendamento
        {
            get { return dataAgendamento; }
            set
            {
                dataAgendamento = value;
            }
        }
    }
}
