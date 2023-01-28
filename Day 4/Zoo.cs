namespace Lab4;

public delegate void AnimalDeath(Animal animal);

public class Zoo
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public void Add(Animal newAnimal)
    {
        Animals.Add(newAnimal);
    }

    public void AnimalDie(Animal animal)
    {
        Animals.Remove(animal);
    }

    public void DisplayAllAnimalCollections()
    {
        foreach (Animal animal in Animals)
        {
            Console.WriteLine($"Animals loop - {animal}");
        }
    }
}

public class Animal
{
    public event AnimalDeath DeathEvent;

    public int Age { get; set; }

    public void Die()
    {
        if (DeathEvent is not null)
        {
            Console.WriteLine("Animal is dead...");
            DeathEvent.Invoke(this);
        }
    }
}
