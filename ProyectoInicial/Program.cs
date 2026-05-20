namespace ProyectoInicial
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            // Constantes
            const double PI = 3.14159;
            Console.WriteLine(PI);
            //PI = 4; // Esto causará un error de compilación, ya que PI es una constante

            sumar(12,56);
            dividir(12, 1);// si le pasamos 0 se lanza una excepción
            Console.WriteLine(restar(4, 6));

            int edad = 16;
            Console.WriteLine("Veo que tu edad es de "+edad);
            

            Console.WriteLine("¿Cuál es tu edad?");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veo que tu edad es de " + edad);
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
