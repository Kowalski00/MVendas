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
            Console.WriteLine("\n[]-- Cadastro de Vendas --[]");
            Console.WriteLine("Digite o CPF do Cliente: ");
            string Cpf = Console.ReadLine();
            v.Cliente = ClienteDAO.buscarCli(Cpf);
            if (v.Cliente!=null) {
                Console.WriteLine("Digite o CPF do Vendedor: ");
                v.Vendedor.Cpf = Console.ReadLine();
                v.Vendedor = VendedorDAO.buscarVen(v.Vendedor.Cpf);
                if (v.Vendedor != null) {
                    Console.WriteLine("Digite o Nome do Produto: ");
                    v.Produto.Nome = Console.ReadLine();
                    v.Produto = ProdutoDAO.buscarProd(v.Produto.Nome);
                    if (v.Produto != null) {
                        Console.WriteLine("Digite a Qtde do Produto: ");
                        v.Qtde = Convert.ToInt32(Console.ReadLine());
                    }
                    else Console.WriteLine("\nProduto inválido.");
                }
                else Console.WriteLine("\nVendedor inválido.");
            }
            else Console.WriteLine("\nCliente inválido.");


            if (VendaDAO.addVendaNaLis(v)) Console.WriteLine("\nCadastro realizado.");
            else Console.WriteLine("\nDados inválidos.");

            v = new Venda();
        }


}
}
