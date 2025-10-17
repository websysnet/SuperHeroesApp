namespace ClasesAvanzadas
{
    public class Persona
    {
        public Guid Id { get; set; }
        public string?  Name { get; set; }

        public int Age { get; set; }

        public Persona()
        {
            Id = Guid.NewGuid();
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Name} y tengo {Age} años.");
        }

    }
}
