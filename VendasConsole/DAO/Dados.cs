using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAO
{
    class Dados
    {
        public static void Inicializar() {

            Cliente cliente = new Cliente {

                Cpf = "04856363956", Nome="José"
            };
            ClienteDAO.addCliNaLista(cliente);

            Vendedor v = new Vendedor { 
                Cpf = "04856363956", Nome="Manoel"
            };
            VendedorDAO.addVenNaLista(v);

            Produto p = new Produto {
                Nome = "Pedra",Preco=10.50,Qtde=5
            };
            ProdutoDAO.addProdNaLista(p);
        } 
    }
}
