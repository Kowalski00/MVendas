using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace VendasConsole.Utils
{
    class Validar
    {
        public static Boolean validarCpf(string cpf)
        {
            cpf = formataStr(cpf);

            if (!tamanhoCpf(cpf)) return false;

            if (cpf.Equals("11111111111") || cpf.Equals("22222222222") || cpf.Equals("33333333333") || cpf.Equals("44444444444") || cpf.Equals("55555555555") ||
                cpf.Equals("66666666666") || cpf.Equals("77777777777") || cpf.Equals("88888888888") || cpf.Equals("99999999999"))
                return false;

            string sCpf = "";
            if (!validarDigito(cpf, 10,  sCpf)) return false;

            if (!validarDigito(cpf, 11,  sCpf)) return false;

            return true;
        }
        public static string formataStr(String CPF) {
            return CPF.Replace(".", "").Replace("-", "");
        }

        public static bool tamanhoCpf(String cpf) => cpf.Length==11;

        public static bool validarDigito(String cpf, int peso, String result) {
            result = "";
            int j = peso, nCpf=0, digito;
            int tam = peso == 10 ? 9 : 10;
            for (int i = 0; i < tam; i++)
            {
                char cCpf = cpf.ToCharArray()[i];
                result += cCpf;
                nCpf += (j - i) * Convert.ToInt32(cpf[i].ToString());
            }
            digito = nCpf % 11;
            if (digito < 2)
                digito = 0;
            else
                digito = 11 - digito;
            result += digito;
            return Convert.ToInt32(cpf[tam].ToString()) != digito ?  false :  true;
        }
    }
 
}
