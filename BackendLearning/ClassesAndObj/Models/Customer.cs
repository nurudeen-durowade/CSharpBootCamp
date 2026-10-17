namespace ClassesAndObj.Models;

public class Customer
{
    public string Name;

    public int Age;

    public Customer(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {Name}");
        Console.WriteLine($"Customer Age: {Age}");
    }   
}