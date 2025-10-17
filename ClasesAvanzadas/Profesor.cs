
namespace ClasesAvanzadas
{
    public class Profesor : Persona
{
    public string? Subject { get; set; }

    public void Enseñar()
    {
        Console.WriteLine($"{Name} está enseñando {Subject}.");
    }

    protected void SaludarProfe()
    {
        Console.WriteLine($"Hola, soy el profesor {Name} y enseño {Subject}.");
    }
}

}
