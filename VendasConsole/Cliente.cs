

using System;

namespace VendasConsole
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



        public Boolean validarCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-","") ;
            if (cpf.Length != 11)
                return false;
            if (cpf.Equals("11111111111") || cpf.Equals("22222222222") || cpf.Equals("33333333333") || cpf.Equals("44444444444") || cpf.Equals("55555555555") ||
                cpf.Equals("66666666666") || cpf.Equals("77777777777") || cpf.Equals("88888888888") || cpf.Equals("99999999999"))
                return false;
            int nCpf = 0, j = 10, d1, d2;
            string sCpf = "";
            for (int i = 0; i < 9; i++)
            {
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
            if (Convert.ToInt32(cpf[9].ToString()) != d1) return false;

            j = 11;
            nCpf = 0;
            for (int i = 0; i < 10; i++)
            {
                nCpf += (j - i) * Convert.ToInt32(cpf[i].ToString());
            }
            d2 = nCpf % 11;
            if (d2 < 2)
                d2 = 0;
            else
                d2 = 11 - d2;
            sCpf += d2;
            return (sCpf.Equals(cpf));
        }
    }
}
