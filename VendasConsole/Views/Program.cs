using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Dados.Inicializar();
            
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
                        CadCliente.Renderizar();
                        break;
                    case 2:
                        LisCliente.Renderizar();
                        break;
                    case 3:
                        CadVendedor.Renderizar();
                        break;
                    case 4:
                        LisVendedor.Renderizar();
                        break;
                    case 5:
                        CadProduto.Renderizar();
                        break;
                    case 6:
                        LisProduto.Renderizar();
                        break;
                    case 7:
                        CadVenda.Renderizar();
                        break;
                    case 8:
                        LisVenda.Renderizar();
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
