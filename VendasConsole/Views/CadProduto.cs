using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("\n[]-- Cadastro de Produtos --[]");
            Console.WriteLine("Digite o nome do Produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Produto: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade do Produto: ");
            p.Qtde = Convert.ToInt32(Console.ReadLine());



            if (ProdutoDAO.addProdNaLista(p))
            {
                Console.WriteLine("\nCadastro realizado.");
            }
            else
                Console.WriteLine("\nJá existe um produto com este nome.");

            p = new Produto();

        }
    }
}
