using System;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("[]======================================[]");
            Console.WriteLine("           Sistema de Vendas");
            Console.WriteLine("[]======================================[]\n");
            Console.WriteLine("Menu");
            Console.WriteLine(" 1- Cadastrar Cliente\n 2- Listar Clientes\n 3- Cadastrar Vendedor\n 4- Listar Vendedores\n 5- Cadastrar Produto\n 6- Listar Produtos\n 7- Registrar Venda\n 8- Listar Vendas\n 9- Listar Vendas por Cliente\n 0- Sair\n");
            Console.Write("Selecione uma opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op) {
                case 1:
                    Console.WriteLine("\n[]-- Cadastro de clientes --[]");
                    break;
                case 2:
                    Console.WriteLine("\n[]-- Listagem de clientes --[]");
                    break;
                case 3:
                    Console.WriteLine("\n[]-- Cadastro de vendedores --[]");
                    break;
                case 4:
                    Console.WriteLine("\n[]-- Listagem de vendedores --[]");
                    break;
                case 5:
                    Console.WriteLine("\n[]-- Cadastro de produtos --[]");
                    break;
                case 6:
                    Console.WriteLine("\n[]-- Listagem de produtos --[]");
                    break;
                case 7:
                    Console.WriteLine("\n[]-- Registro de venda --[]");
                    break;
                case 8:
                    Console.WriteLine("\n[]-- Listagem de vendas --[]");
                    break;
                case 9:
                    Console.WriteLine("\n[]-- Listagem de vendas por cliente --[]");
                    break;
                case 0:
                    Console.WriteLine("\n[]-- Saindo...");
                    break;
            }
        }
    }
}
