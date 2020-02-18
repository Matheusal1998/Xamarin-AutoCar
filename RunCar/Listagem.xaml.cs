using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RunCar
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public class Veiculo
    {
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", preco);
            }
        }

        public FormattedString VeiculoLabel
        {
            get
            {
                return new FormattedString
                {
                    Spans = {
                        new Span { Text = nome },
                        new Span { Text = " - " },
                        new Span { Text = PrecoFormatado, FontAttributes = FontAttributes.Bold } }
                };
            }
            set { }
        }
    }

    public partial class MainPage : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public MainPage()
        {
            InitializeComponent();


            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo { nome = "Celta 1.0", preco = 9000 },
                new Veiculo { nome = "Ideia 1.4", preco = 2700 },
                new Veiculo { nome = "Gran Siena 2.0", preco = 20000 },
                new Veiculo { nome = "C3 1.0", preco = 22000 },
                new Veiculo { nome = "Uno Fire", preco = 11000 },
                new Veiculo { nome = "Sentra 2.0", preco = 53000 },
                new Veiculo { nome = "Astra Sedan", preco = 39000 },
                new Veiculo { nome = "Vectra 2.0 Turbo", preco = 37000 },
                new Veiculo { nome = "Hilux 4x4", preco = 90000 },
                new Veiculo { nome = "Montana Cabine dupla", preco = 57000 },
                new Veiculo { nome = "Outlander 2.4", preco = 99000 },
                new Veiculo { nome = "Brasilia Amarela", preco = 9500 },
                new Veiculo { nome = "Omega Hatch", preco = 8000 }
            };

            this.BindingContext = this;
        }
        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new Detalhes(veiculo));
        }

    }
}
