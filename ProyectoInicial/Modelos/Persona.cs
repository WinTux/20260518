namespace ProyectoInicial.Modelos
{
    internal class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
    }
    namespace sub.modelos
    {
        internal class SubPersona
        {
            private string nombre;
            private string apellido;
            private int edad;
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