using System;
using OOP_DataUseProjecting.DataClasses;
using OOP_DataUseProjecting.Actors;
using OOP_DataUseProjecting.DataUsingInterfaces;

namespace OOP_DataUseProjecting
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor a = new Actor();
            a.Go();
            a.Show();
        }
    }
}
