using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class LisVendedor
    {
        public static void Renderizar()
        {
            Console.WriteLine("\n[]-- Listagem de Vendedores --[]");
            Console.WriteLine("\n[----------------------------]");
            foreach (Vendedor ven in VendedorDAO.retLisVen())
            {
                Console.WriteLine($"Nome: {ven.Nome}, CPF: {ven.Cpf}");
            }
            Console.WriteLine("[----------------------------]");
        }
    }
}
