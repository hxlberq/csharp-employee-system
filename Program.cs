using System;
interface IWorker
{
    string Name{get;}
    void Work();
}
interface IPayable
{
    decimal Salary{get;}
    decimal GetBonus();
}
abstract class Employee : IWorker
{
    public string Name{get;}
    public string Department{get;}
    public abstract void Work();
    public static int Count = 0;
    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
        Count++;
    }
    public void Print()
    {
        Console.WriteLine($"{Name} работает в отделе {Department}");
    }
}
class Developer : Employee, IPayable
{
    public decimal Salary{get;}
    public  decimal GetBonus()
    {
        return Salary * 0.15m;
    }
    public Developer(string name, string department, decimal salary) : base(name,department)
    {
        Salary = salary;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} пишет код");
    }
}
class Designer : Employee, IPayable
{
    public decimal Salary{get;}
    public decimal GetBonus()
    {
        return Salary * 0.1m;
    }
    public Designer(string name, string department, decimal salary) : base(name,department)
    {
        Salary = salary;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} рисует макеты");
    }
}
class Intern : Employee
{
    public Intern(string name,string department) : base(name,department)
    {}
    public override void Work()
    {
        Console.WriteLine($"{Name} учится");
    }
}
class Program
{
    static void Main()
    {
        Employee [] employees =
        {
            new Developer("Иван","Разработка",100000),
            new Designer("Петр","Дизайн",50000),
            new Intern("Саша","Интернет"),
            new Developer("Анна","Разработка",100000),
        };
        foreach(Employee e in employees)
        {
            e.Print();
            e.Work();
            IPayable p = e as IPayable;
            if(p != null)
            Console.WriteLine($"{e.Name} получает зарплату: {p.Salary} и бонус: {p.GetBonus()}");
        }
        Console.WriteLine(Employee.Count);
    }
}
