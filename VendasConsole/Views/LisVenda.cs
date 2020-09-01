using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class LisVenda
    {
        public static void Renderizar(List<Venda> vendas)
        {
            double totalGeral = 0, totalVenda = 0, totalItem = 0;
            Console.WriteLine("\n[]-- Listagem de Vendas --[]");
            Console.WriteLine("\n[-------------------------------------------------------]");
            //foreach (Venda venda in VendaDAO.retLisVen())
            foreach (Venda venda in vendas)
            {
                totalVenda = 0;
                //totalItem = venda.Produto.Preco * venda.Qtde;
                Console.WriteLine("|");
                Console.WriteLine($"|  Cliente: {venda.Cliente.Nome}, Vendedor: {venda.Vendedor.Nome}");
                Console.WriteLine("|  ------ Itens da Venda:");
                foreach (ItemVenda iv in venda.Itens) {
                    Console.WriteLine($"|  * Produto: {iv.Produto.Nome}, Preço: {iv.Preco:C2}, Qtde: {iv.Quantidade} ");
                    totalItem = iv.Preco * iv.Quantidade;
                    Console.WriteLine($"|  Total do item: {totalItem:C2} ");
                    totalVenda += totalItem;
                }

                Console.WriteLine($"|  Total da Venda: {totalVenda:C2} ");
                Console.WriteLine("|");
                totalGeral += totalVenda;
            }
            Console.WriteLine("[-------------------------------------------------------]");
            Console.WriteLine($"|  Total Geral: {totalGeral:C2} ");
        }
    }
}
