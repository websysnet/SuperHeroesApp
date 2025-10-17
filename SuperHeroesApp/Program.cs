// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections.Generic;

List<SuperPower> superpoderes = new List<SuperPower>();
SuperPower superpoder1 = new SuperPower();
superpoder1.Id = 1;
superpoder1.PowerName = "Volar";
superpoder1.Description ="La capacidad de volar por los aires";
superpoder1.Nivel = Level.High;


superpoderes.Add(superpoder1);
SuperPower superpoder2 = new SuperPower();
superpoder2.Id = 2;
superpoder2.PowerName = "Fuerza";
superpoder2.Description = "La capacidad de tener una fuerza sobrehumana";
superpoder2.Nivel = Level.Medium;

superpoderes.Add(superpoder2);


List<SuperHeores> superHeroes = new List<SuperHeores>();
SuperHeores superHeroe1 = new SuperHeores();
superHeroe1.Id = 1;
superHeroe1.Nombre = "Superman";
superHeroe1.SuperPoder = superpoder1;
superHeroes.Add(superHeroe1);


List<SuperHeores> superHeroes2 = new List<SuperHeores>();
SuperHeores superHeroe2 = new SuperHeores();


Console.WriteLine("Lista de Superheroes:");
foreach(var hero in superHeroes)
{
    Console.WriteLine($"ID: {hero.Id}, Nombre: {hero.Nombre}, SuperPoder: {hero.SuperPoder?.PowerName}, Nivel: {hero.SuperPoder?.Nivel}");
}


public class SuperHeores
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public SuperPower? SuperPoder { get; set; }
    public int Age { get; set; }


}

public class SuperPower{
    public int Id { get; set; }
    public string? PowerName { get; set; }   
    public string? Description { get; set; }
    public Level Nivel { get; set; }
}

public enum Level{
    Low,
    Medium,
    High
}

