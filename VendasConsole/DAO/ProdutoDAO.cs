using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAO
{
    class ProdutoDAO
    {
        private static List<Produto> listaProduto = new List<Produto>();

        public static bool addProdNaLista(Produto produto) {
            if (buscarProd(produto.Nome) == null) {
                listaProduto.Add(produto);
                return true;
            }
            return false;
        }

        public static List<Produto> retLisProd() {
            return listaProduto;
        }

        public static Produto buscarProd(String nome) {
            foreach (Produto prod in retLisProd()) {
                if (prod.Nome.Equals(nome)) return prod;
            }
            return null;
        }
    }
}
