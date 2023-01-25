namespace Lab2;

public class AnimalList : List<Animal>
{
    public new void Add(Animal item)
    {
        if (item.Age <= 10)
            base.Add(item);
    }
}

public class Zoo
{
    public AnimalList Animals { get; set; } = new AnimalList();


    public IReadOnlyCollection<Animal> Mammals { get => Animals.Where(x => x is Mammal).ToList().AsReadOnly(); }

    public IReadOnlyCollection<Animal> Birds { get => Animals.Where(x => x is Bird).ToList().AsReadOnly(); }

    public void Add(Animal newAnimal)
    {
        Animals.Add(newAnimal);
    }

    public void AnimalDie(Animal deadAnimal)
    {
        Animals.Remove(deadAnimal);
    }

    public void DisplayAllAnimalCollections()
    {
        foreach (Animal bird in Birds)
        {
            Console.WriteLine($"Birds loop - {bird}");
        }

        foreach (Animal mammal in Mammals)
        {
            Console.WriteLine($"Mammals loop - {mammal}");
        }

        foreach (Animal animal in Animals)
        {
            Console.WriteLine($"Animals loop - {animal}");
        }
    }
}

public abstract class Animal
{
    public int Age { get; set; }

    public abstract void Die();
}

public abstract class Mammal : Animal
{

}

public abstract class Bird : Animal
{

}


public class Tiger : Mammal
{
    public override void Die()
    {
        Console.WriteLine("Tiger is dead");
    }
}

public class Elephant : Mammal
{
    public override void Die()
    {
        Console.WriteLine("Elephant is dead");
    }
}

public class Penguin : Bird
{
    public override void Die()
    {
        Console.WriteLine("Penguin is dead");
    }
}

public class Sparrow : Bird
{
    public override void Die()
    {
        Console.WriteLine("Sparrow is dead");
    }
}
