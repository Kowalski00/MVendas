using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadVenda
    {
        public static void Renderizar() {

            Venda v = new Venda();
            ItemVenda iv = new ItemVenda();
            Produto produto = new Produto();
            Console.WriteLine("\n[]-- Cadastro de Vendas --[]");
            Console.WriteLine("Digite o CPF do Cliente: ");
            string Cpf = Console.ReadLine();
            v.Cliente = ClienteDAO.buscarCli(Cpf);
            if (v.Cliente!=null) {
                Console.WriteLine("Digite o CPF do Vendedor: ");
                v.Vendedor.Cpf = Console.ReadLine();
                v.Vendedor = VendedorDAO.buscarVen(v.Vendedor.Cpf);
                if (v.Vendedor != null)
                {

                    do {
                        produto = new Produto();
                        iv = new ItemVenda();
                        Console.Clear();
                        Console.WriteLine("[]-- Adicionar Produto --[]\n");
                        Console.WriteLine("Digite o Nome do Produto: ");
                        iv.Produto.Nome = Console.ReadLine();
                        produto = ProdutoDAO.buscarProd(iv.Produto.Nome);
                        if (produto != null)
                        {
                            Console.WriteLine("Digite a Qtde do Produto: ");
                            iv.Quantidade = Convert.ToInt32(Console.ReadLine());
                            iv.Preco = produto.Preco;
                            v.Itens.Add(iv);
                        }
                        else Console.WriteLine("\nProduto inválido.");


                        Console.WriteLine("Deseja adicionar mais produtos? (S/N)");
                    }
                    while (Console.ReadLine().ToUpper()=="S");

                    if (VendaDAO.addVendaNaLis(v)) Console.WriteLine("\nCadastro realizado.");
                    else Console.WriteLine("\nDados inválidos.");


                    //if (v.Vendedor != null) {
                    //    Console.WriteLine("Digite o Nome do Produto: ");
                    //    v.Produto.Nome = Console.ReadLine();
                    //    v.Produto = ProdutoDAO.buscarProd(v.Produto.Nome);
                    //    if (v.Produto != null) {
                    //        Console.WriteLine("Digite a Qtde do Produto: ");
                    //        v.Qtde = Convert.ToInt32(Console.ReadLine());
                    //    }
                    //    else Console.WriteLine("\nProduto inválido.");
                }
                else Console.WriteLine("\nVendedor inválido.");
            }
            else Console.WriteLine("\nCliente inválido.");


        }


}
}
