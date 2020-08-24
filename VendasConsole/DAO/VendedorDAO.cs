using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAO
{
    class VendedorDAO
    {
        private static List<Vendedor> listaVendedor = new List<Vendedor>();

        public static bool addVenNaLista(Vendedor Vendedor)
        {
            if (buscarVen(Vendedor.Cpf) == null)
            {
                listaVendedor.Add(Vendedor);
                return true;
            }
            return false;
        }
        public static List<Vendedor> retLisVen()
        {
            return listaVendedor;
        }

        public static Vendedor buscarVen(string CPF)
        {
            foreach (Vendedor Vendedor in retLisVen())
            {
                if (Vendedor.Cpf.Equals(CPF)) return Vendedor;
            }
            return null;
        }
    }
}
