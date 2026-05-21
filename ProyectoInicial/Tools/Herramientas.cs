using System;
using System.Collections.Generic;
using System.Text;

namespace herramientas
{
    internal class Conversor
    {
        public string ConvertirDecimalABinario(int numero)
        {
            if (numero < 0)
                throw new ArgumentOutOfRangeException(nameof(numero), "El número debe ser no negativo.");
            if (numero == 0)
                return "0";
            StringBuilder resultado = new StringBuilder();
            while (numero > 0)
            {
                int residuo = numero % 2;
                resultado.Insert(0, residuo);
                numero /= 2; // numero = numero / 2
            }
            return resultado.ToString();
        }
        public void mostrarNumeros(int inicio, int final, int valorAbuscar) {
            for (int i = inicio; i <= final; i++)
            {
                if (i == valorAbuscar)
                {
                    break;
                }

                Console.WriteLine("Número: " + i);
            }
        }
    }
    public class Compilador { 
    }
}
