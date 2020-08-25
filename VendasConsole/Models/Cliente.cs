

using System;

namespace VendasConsole.Models
{
    class Cliente
    {
        public Cliente()
        {
            CriadoEm = DateTime.Now;

        }
        public DateTime CriadoEm { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

    }
}
