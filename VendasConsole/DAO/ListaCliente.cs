using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.DAO
{
    class ListaCliente
    {
        static List<Cliente> listaCliente = new List<Cliente>();

        public static void addCliNaLista(Cliente cliente) {
            listaCliente.Add(cliente);
            Console.WriteLine("Cliente cadastrado.");
        }
        public static List<Cliente> retLisCli() {
            return listaCliente;
        }
    }
}
