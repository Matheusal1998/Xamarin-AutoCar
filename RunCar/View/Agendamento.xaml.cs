using RunCar.Models;
using RunCar.ViewModel;
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

        public AgendamentoViewModel ViewModel { get; set; }
        public Agendamento( Veiculo veiculo)
        {
            
            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.ViewModel;
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
                Data: {4}", ViewModel.Nome, ViewModel.Email, ViewModel.Telefone, ViewModel.Veiculo, ViewModel.DataAgendamento.ToString("dd/MM/YY"))
                ,"Ok");
        }
        
    }
}