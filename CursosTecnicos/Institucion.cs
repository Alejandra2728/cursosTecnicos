namespace CursosTecnicos
{
    public class Institucion
    {
        private string nombre;
        private List<Alumnos> alumnos;
        private List<Curso> curso;

        public bool registrarAlumno(int dni, string nombre, string apellido, string escolaridad)
        {
            bool noExiste= true;//no existe
          
            foreach (Alumnos alumno in alumnos)
            {
                if (alumno.Dni == dni)
                {
                    noExiste=false;//existe
                }
            }
            if (noExiste)
            {
                Alumnos alum = new(dni, nombre, apellido, escolaridad);
                alumnos.Add(alum);
            }
            else
            {
                Console.WriteLine("Ya esta registrado");
            } 
            return noExiste;
        }
        public string getNombre()
        {
            return nombre;
        }
    }
}
