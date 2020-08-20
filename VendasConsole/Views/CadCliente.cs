using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadCliente
    {
        
        public static void Renderizar() {
            Cliente c = new Cliente();
            Console.WriteLine("\n[]-- Cadastro de clientes --[]");
            Console.WriteLine("Digite o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            c.Cpf = Console.ReadLine();

            
           
                if (Validar.validarCpf(c.Cpf))
                {
                    if (ClienteDAO.addCliNaLista(c))
                        Console.WriteLine("Cliente cadastrado.");
                    else
                        Console.WriteLine("Cliente já existe com este CPF.");
                }
                else
                    Console.WriteLine("\nEste CPF não é válido.");

            c = new Cliente();

        }
        
    }
}
