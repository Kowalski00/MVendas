using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAO
{
    class VendaDAO
    {

        
        private static List<Venda> aux = new List<Venda>();
        private static List<Venda> listaVenda = new List<Venda>();

        public static bool addVendaNaLis(Venda venda) {
            //if (ClienteDAO.buscarCli(venda.Cliente.Cpf) != null && VendedorDAO.buscarVen(venda.Vendedor.Cpf) != null && ProdutoDAO.buscarProd(Produto.Nome) != null)
           // {
                listaVenda.Add(venda);
                return true;
            //}
            //else return false;
        }

        public static List<Venda> retLisVen() => listaVenda;

        public static List<Venda> ListarPorCliente(string cpf) {
            aux.Clear();
            foreach (Venda v in retLisVen()) {
                if (v.Cliente.Cpf == cpf) {
                    aux.Add(v);
                }
            }
            return aux;
        }
        

    }
}
