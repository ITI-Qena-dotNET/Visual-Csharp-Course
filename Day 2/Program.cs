using Lab2;

Console.WriteLine("Hello, World!");

Problem1();
Problem2();

void Problem1()
{
    Zoo zoo = new Zoo();
    zoo.Add(new Tiger() { Age = 20 });
    zoo.Add(new Elephant() { Age = 5 });
    zoo.Add(new Penguin() { Age = 3 });
    zoo.Add(new Sparrow() { Age = 7 });


    zoo.DisplayAllAnimalCollections();

    zoo.AnimalDie(zoo.Animals[1]);
    Console.WriteLine("After first animal death.......");

    zoo.DisplayAllAnimalCollections();
}

void Problem2()
{
    Phonebook phonebook = new();
    phonebook[123] = "Ali";
    phonebook["Hossam"] = 456;
    int phone = phonebook["Ali"];
    
    foreach (var item in phonebook._phonebook)
    {
        Console.WriteLine(item.Key);
    }

}