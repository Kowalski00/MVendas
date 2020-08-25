using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models
{
    class Venda

    {
        public Venda() {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Produto = new Produto();
        }
        public Cliente Cliente { get; set; }

        public DateTime CriadoEm { get; set; }

        public Vendedor Vendedor { get; set; }

        public int Qtde { get; set; }

        public Produto Produto { get; set; }
    }
}
