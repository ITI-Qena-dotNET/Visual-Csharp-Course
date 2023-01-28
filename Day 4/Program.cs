using Lab4;

Problem1();
Problem2();

void Problem1()
{
    Zoo zoo = new();
    Animal animal1 = new() { Age = 4 };
    Animal animal2 = new() { Age = 4 };
    Animal animal3 = new() { Age = 4 };
    Animal animal4 = new() { Age = 4 };

    animal1.DeathEvent += zoo.AnimalDie;
    animal2.DeathEvent += zoo.AnimalDie;
    animal3.DeathEvent += zoo.AnimalDie;
    animal4.DeathEvent += zoo.AnimalDie;

    zoo.Add(animal1);
    zoo.Add(animal2);
    zoo.Add(animal3);
    zoo.Add(animal4);

    animal1.Die();
    zoo.DisplayAllAnimalCollections();

    animal2.Die();
    zoo.DisplayAllAnimalCollections();
}

void Problem2()
{
    Company comp = new()
    {
        Name = "TestCompany",
        Budget = 100_000,
        Employees = new()
    };

    Employee emp1 = new() { Name = "Ahmed", Salary = 5000 };
    Employee emp2 = new() { Name = "Mahmoud", Salary = 1000 };
    Employee emp3 = new() { Name = "Ahmed", Salary = 8000 };
    Employee emp4 = new() { Name = "Hoda", Salary = 4000 };

    emp1.OnSalaryIncreased += comp.ReduceBudgetByEmployeeIncrease;
    emp2.OnSalaryIncreased += comp.ReduceBudgetByEmployeeIncrease;
    emp3.OnSalaryIncreased += comp.ReduceBudgetByEmployeeIncrease;
    emp4.OnSalaryIncreased += comp.ReduceBudgetByEmployeeIncrease;

    comp.Employees.Add(emp1);
    comp.Employees.Add(emp2);
    comp.Employees.Add(emp3);
    comp.Employees.Add(emp4);

    Console.WriteLine($"Current Company Budget: {comp.Budget}");

    comp.Employees[0].IncreaseSalary(10000);

    Console.WriteLine($"Current Company Budget: {comp.Budget}");

    List<Employee> employeesFiltered = comp.FilterEmployees(e => e.Salary > 5000);

    foreach (Employee emp in employeesFiltered)
    {
        Console.WriteLine($"Employee {emp.Name} earns {emp.Salary}");
    }
}