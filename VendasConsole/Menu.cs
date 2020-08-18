using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;

namespace VendasConsole
{
    class Menu
    {
        
        public static Cliente CadCli(Cliente c) {
            Boolean cpfExiste = false;
            Console.WriteLine("\n[]-- Cadastro de clientes --[]");
            Console.WriteLine("Digite o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            c.Cpf = Console.ReadLine();

            foreach (Cliente cCpf in ListaCliente.retLisCli())
            {
                if (c.Cpf.Equals(cCpf.Cpf))
                    cpfExiste = true;
            }
            if (cpfExiste)
                Console.WriteLine("\nJá existe um cliente com este CPF cadastrado.");
            else
            {
                if (c.validarCpf(c.Cpf))
                {
                    return c;
                }
                else
                    Console.WriteLine("\nEste CPF não é válido.");
            }
            return null;
        }
        public static void listarCli()
        {
            Console.WriteLine("\n[]-- Listagem de clientes --[]");
            Console.WriteLine("\n[----------------------------]");
            foreach (Cliente cli in ListaCliente.retLisCli())
            {
                Console.WriteLine($"Nome: {cli.Nome}, CPF: {cli.Cpf}");
            }
            Console.WriteLine("[----------------------------]");
        }
    }
}
