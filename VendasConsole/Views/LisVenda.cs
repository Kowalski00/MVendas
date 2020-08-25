using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class LisVenda
    {
        public static void Renderizar()
        {
            double totalGeral = 0, totalVenda = 0, totalItem = 0;
            Console.WriteLine("\n[]-- Listagem de Vendas --[]");
            Console.WriteLine("\n[-------------------------------------------------------]");
            foreach (Venda venda in VendaDAO.retLisVen())
            {
                totalVenda = 0;
                totalItem = venda.Produto.Preco * venda.Qtde;
                Console.WriteLine("|");
                Console.WriteLine($"|  Cliente: {venda.Cliente.Nome}, Vendedor: {venda.Vendedor.Nome}");
                Console.WriteLine("|  ------ Itens da Venda:");
                Console.WriteLine($"|  Produto: {venda.Produto.Nome}, Preço: {venda.Produto.Preco.ToString("C2")}, Qtde: {venda.Qtde} ");
                Console.WriteLine($"|  Total do item: {totalItem:C2} ");
                totalVenda += totalItem;
                Console.WriteLine($"|  Total da Venda: {totalVenda:C2} ");
                totalGeral += totalVenda;
                Console.WriteLine("|");
            }
            Console.WriteLine("[-------------------------------------------------------]");
            Console.WriteLine($"|  Total Geral: {totalGeral:C2} ");
        }
    }
}
