using System;

// Interfaz para los métodos comunes de los animales
interface IAnimal
{
    int Id { get; set; }
    string Name { get; set; }
    int Age { get; set; }
    void AnimalSound();
}

// Interfaz para métodos específicos de cerdos
interface IPig
{
    void Eat();
    void Sleep();
}

// Clase que implementa las interfaces IAnimal e IPig
class Pig : IAnimal, IPig
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Implementación del método de la interfaz IAnimal
    public void AnimalSound()
    {
        Console.WriteLine("Oink oink!");
    }

    // Implementación de los métodos de la interfaz IPig
    public void Eat()
    {
        Console.WriteLine("el cerdito esta comiendo.");
    }

    public void Sleep()
    {
        Console.WriteLine("el cerdito esta durmiendo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Crear un objeto Pig
        myPig.Id = 1;
        myPig.Name = "Piggy";
        myPig.Age = 2;

        Console.WriteLine($"cerdito ID: {myPig.Id}");
        Console.WriteLine($"nombre cerdito : {myPig.Name}");
        Console.WriteLine($"edad del cerdito: {myPig.Age}");
        myPig.AnimalSound();

        // Ejemplos de métodos específicos de cerdos
        myPig.Eat();
        myPig.Sleep();
    }
}