using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RunCar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agendamento 
    {
        public Veiculo Veiculo { get; set; }
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
        
        public Agendamento( Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            InitializeComponent();
            this.BindingContext = this;
        }
        private void Button_Clicked(object sender, EventArgs e)  
        {
            DisplayAlert("Agendamento", 
                string.Format(
                @"
                Nome:{0} 
                Email:{1} 
                Telefone:{2} 
                Veiculo: {3}
                Data: {4}", Nome, Email, Telefone,Veiculo ,DataAgendamento.ToString("dd/MM/YY"))
                ,"Ok");
        }
        
    }
}