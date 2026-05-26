namespace ProyectoInicial.Modelos
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        public Persona(string nom,string ape,int ed) { 
            nombre = nom;
            apellido = ape;
            edad = ed;
        }
        
        public Persona(int edad, string nombre, string apellido) { 
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona()
        {
            nombre = "NA";
            apellido = "NA";
            edad = 18;
        }
        public Persona(int edad) {
            nombre = "NA";
            apellido = "NA";
            this.edad = edad;
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
    public class Estudiante : Persona, ICiudadano {
        public string matricula;
        public Estudiante(string nombre, string apellido, int edad, string mat) : base(nombre, apellido, edad) { 
            matricula = mat;
        }
        public Estudiante() : base(){
            matricula = "100";
            _nombre = "NA";
            _apellido = "NA";
            _edad = 18;
        }
        public void trabajar()
        {
            Console.WriteLine("El estudiante está estudiando");
        }

        public void votar()
        {
            Console.WriteLine("El estudiante está votando");
        }

        public void pagarImpuestos()
        {
            Console.WriteLine("El estudiante está pagando impuestos");
        }
    }
    public class Profesor : ICiudadano{
        public string materia;
        public Profesor(string mat)
        {
            materia = mat;
        }
        public void votar() { 
        }
        public void pagarImpuestos()
        {
        }
    }
    public sealed class EstudianteUniversitario : Estudiante
    {
        public string carrera;
        public EstudianteUniversitario(string nombre, string apellido, int edad, string mat, string car) : base(nombre, apellido, edad, mat)
        {
            carrera = car;
        }
    }
    public interface ICiudadano { 
        void votar();
        void pagarImpuestos();
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