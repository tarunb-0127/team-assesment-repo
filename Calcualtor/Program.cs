using System;

 
 void Add (int a,b){
    int s = a+b; 
    console.WriteLine(s);
 }
 
 void add(int a,int b, int c) {
    Console.WriteLine("Number 1:");
    int a = Convert.intToInt32(Console.ReadLine());
    Console.WriteLine("Number 2" );
    int b = Convert.intToInt32(Console.ReadLine());
    Console.WriteLine("Number 3");
    int c = Convert.intToInt32(Console.ReadLine()); 
    add(a,b,c);
    Console.WriteLine("Addition")
}

class Program
{
    static void Main()
    {
        Console.Write("Hello");
        add(1,2);
    }
}