using RunCar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RunCar.ViewModel
{
    public class AgendamentoViewModel
    {

        public AgendamentoModel AgendamentoModel { get; set; }

        public Veiculo Veiculo { get { return AgendamentoModel.veiculo; } set { AgendamentoModel.veiculo = value; } }
        public string Nome { get { return AgendamentoModel.Nome; } set { AgendamentoModel.Nome = value; } }
        public string Email { get { return AgendamentoModel.Email; } set { AgendamentoModel.Email = value; } }
        public int Telefone { get { return AgendamentoModel.Telefone; } set { AgendamentoModel.Telefone = value; } }
        TimeSpan horaAgendamento;
        public DateTime DataAgendamento
        {
            get { return AgendamentoModel.DataAgendamento; }
            set
            {
                AgendamentoModel.DataAgendamento = value;
            }
        }

        public AgendamentoViewModel(Veiculo veiculo)
        {
            this.AgendamentoModel = new AgendamentoModel();
            this.AgendamentoModel.veiculo = veiculo;
        }

    }
}
