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

        public const int freio_abs = 500;
        public const int ar_condicionado = 1000;
        public const int mp3 = 300;

        bool TemFreioAbs;
        bool TemArCondicionado;
        bool TemMP3;

        public bool temArCondionado{

            get{ return TemArCondicionado;}
            set{
                TemArCondicionado = value;
                if (TemArCondicionado)
                    DisplayAlert("Ar condicionado", "Ligado!", "Ok");
                else
                    DisplayAlert("Ar condicionado", "Desligado!", "Ok");


                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }

        }

        public bool temMP3
        {
            get { return TemMP3; }
            set
            {
                TemMP3 = value;

                if (TemMP3)
                    DisplayAlert("MP3", "Ligado!", "Ok");
                else
                    DisplayAlert("MP3", "Desligado", "Ok!");


                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool temFreioAbs
        {
            get { return TemFreioAbs; 
            
            }
            set
            {
                TemFreioAbs = value;
                if (TemFreioAbs)
                {
                    DisplayAlert("Freio ABS", "Ligado!", "Ok");
                  
                }
                else
                {
                    DisplayAlert("Freio ABS", "Deligado!", "Ok");
                   
                }

                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", 
                    (temFreioAbs? freio_abs : 0)+
                    (temArCondionado ? ar_condicionado : 0)+
                    (temMP3? mp3 : 0)+
                    Veiculo.preco
                    );
            }
        }

        public string TextFreio
        {
            get
            {
                return string.Format("Freio ABS - R$ {0} ", freio_abs);
            }
        }
        public string TextAr
        {
            get
            {
                return string.Format("Ar condicionado - R$ {0}", ar_condicionado);
            }
        }
        public string TextMP3
        {
            get
            {
                return string.Format("MP3 Player - R$ {0}", mp3);
            }
        }
        public Veiculo Veiculo { get; set; }
        public Detalhes(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            InitializeComponent();
            this.BindingContext = this;




        }

        private void botaoProximo_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Agendamento( this.Veiculo));
        }
       
    }
}