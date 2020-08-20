using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAO
{
    class ClienteDAO
    {
        private static List<Cliente> listaCliente = new List<Cliente>();

        public static bool addCliNaLista(Cliente cliente) {
            if (buscarCli(cliente.Cpf) == null)
            {
                listaCliente.Add(cliente);
                return true;
            }
            return false;
        }
        public static List<Cliente> retLisCli() {
            return listaCliente;
        }

        public static Cliente buscarCli(string CPF) {
            foreach (Cliente cliente in retLisCli())
            {
                if (cliente.Cpf.Equals(CPF)) return cliente;
            }
            return null;
        }
    }
}
