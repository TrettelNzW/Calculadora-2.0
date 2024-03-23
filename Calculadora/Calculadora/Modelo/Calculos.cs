using System;

namespace Calculadora.Modelo
{
    public class Calculos
    {
        public int N1 { get; private set; }
        public int N2 { get; private set; }
        public int Resposta { get; private set; }

        public Calculos(int n1, int n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public void Calcular(string op)
        {
            switch (op)
            {
                case "+":
                    Resposta = N1 + N2;
                    break;
                case "-":
                    Resposta = N1 - N2;
                    break;
                case "*":
                    Resposta = N1 * N2;
                    break;
                case "/":
                    if (N2 != 0)
                    {
                        Resposta = N1 / N2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    break;
            }
        }
    }
}