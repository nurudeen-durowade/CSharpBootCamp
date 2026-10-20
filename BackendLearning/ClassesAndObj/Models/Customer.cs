namespace ClassesAndObj.Models;

public class Customer
{
    public string Name { get;  set; } 

    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Age must be non-negative."
                );
            }
            _age = value;
        }
    }

    // public Customer(string name, int age)
    // {
    //     Name = name;
    //     Age = age;
    // }

    // Parameterless constructor
    public Customer()
    {
        Name = "Unknown";
        Age = 0;
    }

    public void UpdateAge(int newAge)
    {
        if (newAge < 0)
        {
            Console.WriteLine("Age must be a positive number.");
            return;
        }
        Age = newAge;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {Name}");
        Console.WriteLine($"Customer Age: {Age}");
    }   
}