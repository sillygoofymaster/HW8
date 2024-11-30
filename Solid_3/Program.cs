using System;

interface IShape
{
    int CalculateArea();
}

class Rectangle:IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int CalculateArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : IShape
{
    public int Side {get; set; } 
    public int CalculateArea()
    {
        return Side * Side;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
        IShape rect = new Square() { Side = 15 };

            Console.WriteLine(rect.CalculateArea());

            Console.ReadKey();
        }
    }