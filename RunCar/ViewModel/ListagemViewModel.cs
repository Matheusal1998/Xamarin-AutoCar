using RunCar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RunCar.ViewModel
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculo().Veiculos;

        }
    }
}
