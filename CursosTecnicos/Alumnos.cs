namespace CursosTecnicos
{
    public class Alumnos
    {
        
        private int dni;
        private string nombre;
        private string apellido;
        private string escolaridad;

        public Alumnos(int dni, string nombre, string apellido, string escolaridad)
        {
            this.Dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.escolaridad = escolaridad;
        }

        public int Dni { get => dni; set => dni = value; }
    }
}
