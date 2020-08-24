using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAO;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadVendedor
    {

        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine("\n[]-- Cadastro de Vendedores --[]");
            Console.WriteLine("Digite o nome do Vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Vendedor: ");
            v.Cpf = Console.ReadLine();



            if (Validar.validarCpf(v.Cpf))
            {
                if (VendedorDAO.addVenNaLista(v))
                    Console.WriteLine("Vendedor cadastrado.");
                else
                    Console.WriteLine("Vendedor já existe com este CPF.");
            }
            else
                Console.WriteLine("\nEste CPF não é válido.");

            v = new Vendedor();

        }
    }
}
