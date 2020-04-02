using System;
using System.Collections.Generic;
using System.Text;

namespace RunCar.Models
{
   public class ListagemVeiculo
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemVeiculo()
        {
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
        } 
    }
}
