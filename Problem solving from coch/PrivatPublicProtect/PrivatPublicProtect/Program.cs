using System;


// Public class with public and private members
public class Car
{
    // Public field
    public string Model;

    // Private field
    private int year;

    // Constructor
    public Car(string model, int year)
    {
        Model = model;
        //Year = year;
        this.year = year;
    }

    // Public method
    public void DisplayModel()
    {
        Console.WriteLine($"Model: {Model}");
    }

    // Private method
    private void DisplayYear()
    {
        Console.WriteLine($"Year: {year}");
    }


    // Public method accessing private method
    public void DisplayDetails()
    {
        DisplayModel();  // Accessing public method
        DisplayYear();   // Accessing private method
    }
}

// Internal class with internal members
internal class InternalClass
{
    // Internal method
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method called");
    }
}

// Example of inheritance with protected and protected internal members
public class Animal
{
    protected string name;

    protected void SetName(string name)
    {
        this.name = name;
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{name} says Woof!");
    }
}

// Static class with static members
public static class MathHelper
{
    // Static method
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Static field
    public static readonly double Pi = 3.14159265359;
}

class Program
{
    static void Main()
    {
        // Using public class and members
        Car myCar = new Car("Toyota", 2020);
        myCar.DisplayModel();     // Output: Model: Toyota
        myCar.DisplayDetails();   // Output: Model: Toyota, Year: 2020 (private method accessed via public method)

        // Using internal class and member
        InternalClass internalObj = new InternalClass();
        internalObj.InternalMethod();  // Output: Internal method called

        // Using protected and protected internal with inheritance
        Dog myDog = new Dog();

        myDog.Bark();  // Output: Buddy says Woof!

        // Using static class and members
        int sum = MathHelper.Add(5, 3);  // sum will be 8
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Pi: {MathHelper.Pi}");

        // Wait for user input before closing console window
        Console.ReadLine();
    }
}
