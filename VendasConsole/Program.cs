using System;
using System.Collections.Generic;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Cliente c = new Cliente();
            List<Cliente> listaCli = new List<Cliente>();
            do
            {   
                Console.Clear();
                Console.WriteLine("[]======================================[]");
                Console.WriteLine("           Sistema de Vendas");
                Console.WriteLine("[]======================================[]\n");
            
                Console.WriteLine("\nMenu");
                Console.WriteLine(" 1- Cadastrar Cliente\n 2- Listar Clientes\n 3- Cadastrar Vendedor\n 4- Listar Vendedores\n 5- Cadastrar Produto\n 6- Listar Produtos\n 7- Registrar Venda\n 8- Listar Vendas\n 9- Listar Vendas por Cliente\n 0- Sair\n");
                Console.Write("Selecione uma opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("\n[]-- Cadastro de clientes --[]");
                        Console.WriteLine("Digite o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();
                        listaCli.Add(c);
                        c = new Cliente();
                        break;
                    case 2:
                        Console.WriteLine("\n[]-- Listagem de clientes --[]");
                        Console.WriteLine("\n[----------------------------]");
                        foreach (Cliente cli in listaCli)
                        {
                            Console.WriteLine($"Nome: {cli.Nome}, CPF: {cli.Cpf}");

                        }
                        Console.WriteLine("[----------------------------]");
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
                    default:
                        Console.WriteLine("\n[]-- Não existe esta opção...");
                        break;
                }
                Console.Write("\n[]-- Pressione qualquer botão para continuar: ");
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
