
namespace ClasesAvanzadas
{
    public class Estudiante : Persona
    {
        public string? School { get; set; }

        public List<Profesor>? profesores { get; set; }

        public void Estudiar()
        {
            Console.WriteLine($"{Name} está estudiando en {School}.");
        }

        public void MostrarProfesores(List<Profesor>listaProfores)
        {
            if(listaProfores != null)
            {
                foreach(var profe in listaProfores)
                {
                    Console.WriteLine($"Profesor: {profe.Name}, Materia: {profe.Subject}");
                }
            }
            
        }
    }

}
