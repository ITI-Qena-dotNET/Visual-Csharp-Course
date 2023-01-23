using System.Collections;

namespace Lab1;

public interface IPayable
{
    int Salary { get; set; }

    void ShowPayment();
}

public class Employee : IPayable
{
    private int _salary;
    private string _name;

    public Employee(int salary, string name)
    {
        _salary = salary;
        _name = name;
    }

    public int Salary 
    { 
        get => _salary;
        set => _salary = value; 
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public void ShowPayment()
    {
        Console.WriteLine($"Employee's Salary is {Salary}");
    }
}

public class Trainee : IPayable
{
    private int _salary;
    private string _name;

    public Trainee(int salary, string name)
    {
        _salary = salary;
        _name = name;
    }

    public int Salary
    {
        get => _salary;
        set => _salary = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public void ShowPayment()
    {
        Console.WriteLine($"Trainee's Salary is {Salary}");
    }

    public override string ToString()
    {
        return $"{Name} - Salary: {Salary}";
    }
}

public class TraineeComparer : IComparer<Trainee>
{
    public int Compare(Trainee? x, Trainee? y)
    {
        if (x.Salary > y.Salary)
            return 1;
        else if (x.Salary == y.Salary)
            return 0;
        else
            return -1;
    }
}
