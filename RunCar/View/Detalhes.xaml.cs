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
    public partial class Detalhes
    {


        public Veiculo Veiculo;
        public Detalhes(Veiculo veiculo)
        {

            InitializeComponent();
            this.Veiculo = veiculo;
            this.BindingContext = new DetalheViewModel(Veiculo);




        }

        private void botaoProximo_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Agendamento(this.Veiculo));
        }

    }
}