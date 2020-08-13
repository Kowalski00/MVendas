using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
                        int cpfExiste = 0;
                        Console.WriteLine("\n[]-- Cadastro de clientes --[]");
                        Console.WriteLine("Digite o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();

                        foreach(Cliente cCpf in listaCli) {
                            if (c.Cpf.Equals(cCpf.Cpf))
                                cpfExiste = 1;
                        }
                        if (cpfExiste == 1)
                            Console.WriteLine("\nJá existe um cliente com este CPF cadastrado.");
                        else
                        {
                            if(validarCpf(c.Cpf))
                                listaCli.Add(c);
                            else
                                Console.WriteLine("\nEste CPF não é válido.");
                        }
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
        public static Boolean validarCpf(string cpf)
        {
            int nCpf=0,j=10,d1,d2;
            string sCpf = "";
            for (int i = 0; i < 9; i++) {
                char cCpf = cpf.ToCharArray()[i];
                sCpf += cCpf;
                nCpf += (j - i) * Convert.ToInt32(cpf[i].ToString());
            }
            d1 = nCpf % 11;
            if (d1 < 2)
                d1 = 0;
            else
                d1 = 11 - d1;
            sCpf += d1;
            j = 11;
            nCpf = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                    nCpf += d1 * 2;
                else
                {
                    nCpf += (j - i) * Convert.ToInt32(cpf[i].ToString());
                }
            }
            d2 = nCpf % 11;
            if (d2< 2)
                d2 = 0;
            else
                d2 = 11 - d2;
            sCpf += d2;
            return (sCpf.Equals(cpf));
        }
    }
}
