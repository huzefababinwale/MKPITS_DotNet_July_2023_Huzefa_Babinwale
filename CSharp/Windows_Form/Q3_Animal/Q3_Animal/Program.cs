
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Animal(string name, int age) { Name = name; Age = age; }

    public virtual void Sound()
    {
        Console.WriteLine("Every Animal Makes Sound");
    }
}

public class Mammal : Animal
{
    public Mammal(string name, int age) : base(name, age)
    {

    }
    public override void Sound()
    {
        Console.WriteLine("Sound of Mammals");
    }
}

public class Reptiles : Animal
{
    public Reptiles(string name, int age) : base(name, age)
    {

    }
    public override void Sound()
    {
        Console.WriteLine("Sound of Reptile");
    }
}

public class Bird : Animal
{
    public Bird(string name, int age) : base(name, age)
    {

    }
    public override void Sound()
    {
        Console.WriteLine("These Sound is for Bird");
    }
}

class Lion : Mammal
{
    public Lion(string name, int age) : base(name, age)
    {

    }
    public override void Sound()
    {
        Console.WriteLine("Lion is Roaring");
    }
}

class Snake : Reptiles
{
    public Snake(string name, int age) : base(name, age)
    {

    }
    public override void Sound()
    {
        Console.WriteLine("Snake Hisssssssssssss");
    }
}

class Eagle : Bird
{
    public Eagle(string name, int age) : base(name, age)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("I Fly with Scrapppy Sound");
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        Lion lion = new Lion("simba ",7);
        Snake snake = new Snake("Chiili Flake",3);
        Eagle eagle = new Eagle("Sheru",6);
        Animal[] animals = { lion, snake, eagle };

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name + "," + animal.Age);
            animal.Sound();
        }
        Console.ReadLine();
    }
}
