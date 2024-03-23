using System;

namespace Calculadora.Modelo
{
    public class Validacao
    {
        public string Num1 { get; private set; }
        public string Num2 { get; private set; }
        public int N1 { get; private set; }
        public int N2 { get; private set; }
        public string Mensagem { get; private set; }

        public Validacao(string num1, string num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public bool Validar()
        {
            Mensagem = "";
            if (!int.TryParse(Num1, out int n1) || !int.TryParse(Num2, out int n2))
            {
                Mensagem = "Insira apenas Números.";
                return false;
            }

            N1 = n1;
            N2 = n2;
            return true;
        }
    }
}