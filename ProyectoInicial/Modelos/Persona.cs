namespace ProyectoInicial.Modelos
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        public Persona(string nom,string ape,int ed) { 
            nombre = nom;
            apellido = ape;
            edad = ed;
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int edad
        {
            get { return _edad; }
            set
            {
                if (value >= 18 && value <= 60)
                    _edad = value;
            }
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("El nombre de la persona es: " + unirNombreCompleto());
            Console.WriteLine("La edad de la persona es: " + edad);
        }
        public void trabajar() { 
            Console.WriteLine("La persona está trabajando");
        }

        private string unirNombreCompleto()
        {
            return nombre + " " + apellido;
        }
    }
    public class Estudiante : Persona {
        public string matricula;
    }
    namespace sub.modelos
    {
        internal class SubPersona
        {
            private string _nombre;
            private string _apellido;
            private int _edad;
            public string nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }
            public string apellido
            {
                get { return _apellido; }
                set { _apellido = value; }
            }
            public int edad
            {
                get { return _edad; }
                set { if(value>=18 && value <=60)
                        _edad = value;
                }
            }
        }
    }
}

namespace herramientas {
    using ProyectoInicial.Modelos.sub.modelos;
    public class AlgunaHerramienta
    {
        Compilador comp = new Compilador();
        SubPersona s = new SubPersona();
    }
}

namespace universidad {
    namespace pregrado
    {
        public class Estudiante
        {
            private string matricula;
        }
    }
    namespace postgrado {
        public class Estudiante
        {
            private string matricula;
            private string profesion;
        }
    }
    
}