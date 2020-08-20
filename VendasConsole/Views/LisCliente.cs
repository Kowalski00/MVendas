using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class LisCliente
    {
        public static void Renderizar()
        {
            Console.WriteLine("\n[]-- Listagem de clientes --[]");
            Console.WriteLine("\n[----------------------------]");
            foreach (Cliente cli in ClienteDAO.retLisCli())
            {
                Console.WriteLine($"Nome: {cli.Nome}, CPF: {cli.Cpf}");
            }
            Console.WriteLine("[----------------------------]");
        }
    }
}
