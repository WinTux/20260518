using herramientas;
using ProyectoInicial.Modelos;

//using ProyectoInicial.Modelos;
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
            sumar(12, 56);

            Console.WriteLine("Ingrese dos numeros para dividir:");
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                dividir2(num1, num2);// si le pasamos 0 se lanza una excepción
                dividir(num1, num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error por divisón entre 0: " + ex.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debes ingresar números válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Este bloque se ejecuta siempre, haya o no excepciones.");
            }
            Console.WriteLine(restar(4, 6));

            int edad = 16;
            Console.WriteLine("Veo que tu edad es de " + edad);


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
            if (esNumero)
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
            ProyectoInicial.Modelos.Estudiante estPostgrado = new ProyectoInicial.Modelos.Estudiante();
            #endregion
            try
            {
                string binario = cv.ConvertirDecimalABinario(10);
                Console.WriteLine("El número 10 en binario es: " + binario);

                Console.WriteLine("Ingrese dos numeros para el ejemplo de for y un numero para detenernos");
                int inicio = Convert.ToInt32(Console.ReadLine());
                int final = Convert.ToInt32(Console.ReadLine());
                int valorAbuscar = Convert.ToInt32(Console.ReadLine());
                cv.mostrarNumeros(inicio, final, valorAbuscar);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("TRABAJANDO CON OBJETOS");
            ProyectoInicial.Modelos.Persona per02 = new ProyectoInicial.Modelos.Persona();
            per02.nombre = "Pepe";
            per02.apellido = "Perales";
            per02.edad = 27;
            per02.mostrarInformacion();
            per02.edad = -99;
            per02.mostrarInformacion();
            per02.trabajar();

            ProyectoInicial.Modelos.Estudiante est01 = new ProyectoInicial.Modelos.Estudiante();
            est01.nombre = "Maria";
            est01.apellido = "Gonzalez";
            est01.edad = 22;
            est01.matricula = "12345";

            // Polimorfismo
            Profesor prof01 = new Profesor("Matemáticas");
            prof01.votar();
            est01.votar();

            // Estructuras estáticas
            // Arreglo (array)
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Arreglos - unidimensionales");
            int[] numeros = new int[5];
            numeros[0] = 10; numeros[1] = 20;
            numeros[2] = 30; numeros[3] = 40; numeros[4] = 50;
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();
            Console.WriteLine("Arreglos - bidimensionales");
            int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("elemento 1,2: "+matriz[1,2]);

            Console.WriteLine("Arreglos - tridimensionales");
            int[,,] cubo = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            // Continuando con el polimorfismo
            Profesor[] profesores = new Profesor[2];
            profesores[0] = new Profesor("Física");
            profesores[1] = prof01;
            ProyectoInicial.Modelos.Estudiante[] estudiantes = new ProyectoInicial.Modelos.Estudiante[2];
            estudiantes[0] = est01;
            estudiantes[1] = new ProyectoInicial.Modelos.Estudiante();

            ICiudadano[] ciudadanos = new ICiudadano[4];
            ciudadanos[0] = prof01;
            ciudadanos[1] = est01;
            ICiudadano ciudadanoDelMundo = new Profesor("Química");
            Profesor profAux = (Profesor)ciudadanoDelMundo;// casteo o conversión explícita
        }
        public static void sumar(int a, int b)
        {
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
        //Usando throws para indicar que el método puede lanzar una excepción

        public static void dividir2 (int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            Console.WriteLine(a / b);
        }
    }
}
