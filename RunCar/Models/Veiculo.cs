using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RunCar.Models
{
    public class Veiculo
    {
        public const int freio_abs = 500;
        public const int ar_condicionado = 1000;
        public const int mp3 = 300;

        public string nome { get; set; }
        public decimal preco { get; set; }


        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", preco);
            }
        }

        public bool TemFreioAbs;
        public bool TemArCondicionado;
        public bool TemMP3;

        public string PrecoTotalFormatado()
        {
            return string.Format("Valor Total: R$ {0}",
                     (TemFreioAbs ? Veiculo.freio_abs : 0) +
                     (TemArCondicionado ? Veiculo.ar_condicionado : 0) +
                     (TemMP3 ? Veiculo.mp3 : 0) +
                     preco
                     );
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
}
