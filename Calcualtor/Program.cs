using System;
 
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
 
    public int Add(int a, int b, int c)
    {
        return this.Add(a, b) + c;
    }
}
 
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
 
        Console.WriteLine("Sum of 5 and 3: " + calc.Add(5, 3));
        Console.WriteLine("Sum of 5, 3, and 2: " + calc.Add(5, 3, 2));
    }
}