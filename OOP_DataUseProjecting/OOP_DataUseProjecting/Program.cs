using System;
using OOP_DataUseProjecting.Actors;

namespace OOP_DataUseProjecting
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor a = new Actor();
            Console.WriteLine(a.Coordinates.x + " " + a.Coordinates.y);
            a.Go();
            Console.WriteLine(a.Coordinates.x + " " + a.Coordinates.y);
            a.Show();
        }
    }
}
