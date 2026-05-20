using herramientas;

using universidad.postgrado;
// Usando alias en using
using EstPregrado = universidad.pregrado.Estudiante; 

namespace miNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejemplos iniciales
            Console.WriteLine("¡Hola mundo!");
            // Tipos de datos y variables
            int numero2;
            numero2 = 506;
            int numero = 42;
            short shortNumber = 32767;
            byte byteNumber = 255;
            float decimalNumber = 3.14f;
            double doubleNumber = 3.14159;
            string texto = "¡Hola, C#!";
            Console.WriteLine(3.14159);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(numero + decimalNumber);
            doubleNumber = 2.71828;
            Console.WriteLine(doubleNumber);
            #endregion
            #region constantes
            // Constantes
            const double PI = 3.14159;
            Console.WriteLine(PI);
            //PI = 4; // Esto causará un error de compilación, ya que PI es una constante
            #endregion
            sumar(12,56);
            dividir(12, 1);// si le pasamos 0 se lanza una excepción
            Console.WriteLine(restar(4, 6));

            int edad = 16;
            Console.WriteLine("Veo que tu edad es de "+edad);
            

            Console.WriteLine("¿Cuál es tu edad?");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veo que tu edad es de " + edad);

            // Parse
            Console.WriteLine("Ingrese un num entero");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un num decimal");
            float numDecimal = float.Parse(Console.ReadLine());

            // TryParse 
            Console.WriteLine("Ingrese un num entero (TryParse)");
            int res = 0;
            bool esNumero = false;
            esNumero = int.TryParse(Console.ReadLine(), out res);
            if(esNumero)
            {
                Console.WriteLine("El valor ingresado es: " + res);
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número entero válido.");
            }

            #region para namespaces
            ProyectoInicial.Modelos.Persona p01 = new ProyectoInicial.Modelos.Persona();
            Conversor cv = new Conversor();
            EstPregrado estPregrado = new EstPregrado();
            Estudiante estPostgrado = new Estudiante();
            #endregion
        }
        public static void sumar(int a, int b) {
            Console.WriteLine(a + b); 
        }
        public static void dividir(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static int restar(int a, int b)
        {
            return a - b;
        }
    }
}
