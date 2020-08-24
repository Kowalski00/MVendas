using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class LisProduto
    {
        public static void Renderizar()
        {
            Console.WriteLine("\n[]-- Listagem de Produtos --[]");
            Console.WriteLine("\n[-----------------------------------]");
            foreach (Produto prod in ProdutoDAO.retLisProd())
            {
                Console.WriteLine($"Nome: {prod.Nome}, Preço: R${prod.Preco}, Qtde: {prod.Qtde}");
            }
            Console.WriteLine("[-----------------------------------]");
        }
    }
}
