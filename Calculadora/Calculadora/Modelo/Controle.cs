using System;

namespace Calculadora.Modelo
{
    public class Controle
    {
        public string Num1 { get; private set; }
        public string Num2 { get; private set; }
        public string Mensagem { get; private set; }
        public string Resultado { get; private set; }

        public Controle(string num1, string num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public bool Validar()
        {
            
            return true; 
        }

        public void Executar(string op)
        {
          
        }
    }
}