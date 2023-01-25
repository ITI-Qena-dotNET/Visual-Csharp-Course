using Lab1;

Console.WriteLine("*************************** Lab 1 Problem ***************************");

Problem1();
Problem2();
Problem3();

void Problem1()
{
    Point p1 = new()
    {
        X = 1,
        Y = 2,
        Name = "Point 1"
    };

    Point p2 = new()
    {
        X = 2,
        Y = 3,
        Name = "Point 2"
    };

    Point p3 = p2.Clone() as Point;

    Point[] points = new[] { p3, p2, p1 };

    Array.Sort(points);

    foreach (var p in points)
    {
        Console.WriteLine(p.ToString());
    }
}

void Problem2()
{
    Employee employee= new(1000, "Ahmed");
    Trainee trainee3 = new(12000, "Khaled");
    Trainee trainee4 = new(7000, "Hana");
    Trainee trainee1 = new(2000, "Mahmoud");
    Trainee trainee2 = new(5000, "Samar");

    Trainee[] trainees = new[] { trainee3, trainee4, trainee1, trainee2 };

    Array.Sort(trainees, new TraineeComparer());

    foreach (var trainee in trainees)
    {
        Console.WriteLine(trainee.ToString());
    }
}


void Problem3()
{
    Phonebook phonebook = new();
    phonebook[123] = "Ali";
    phonebook["Hossam"] = 456;
    int phone = phonebook["Ali"];
    Console.WriteLine(phone);
}