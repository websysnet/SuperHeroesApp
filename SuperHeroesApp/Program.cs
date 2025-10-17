// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




public class SuperHeores
{
    public int Id { get; set; }
    public string Nombre { get; set; }    
    public SuperPower SuperPoder { get; set; }
    public int Age { get; set; }    
    
    
}

public class SuperPower{
    public int Id { get; set; }
    public string PowerName { get; set; }   
    public string Description { get; set; }
    public int Level { get; set; }
}

public enum {
    Low,
    Medium,
    High
}

