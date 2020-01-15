using System;
using System.Collections.Generic;
using System.Text;
using OOP_DataUseProjecting.DataClasses;

namespace OOP_DataUseProjecting.DataUsingInterfaces
{
    interface ICanGo
    {
        HorizontalCoordinates Coordinates { get; }
        GoingParams Movement { get; }

        void Go();
    }

    class Goer : ICanGo
    {
        public HorizontalCoordinates Coordinates { get; set; }

        public GoingParams Movement { get; set; }

        public Goer(HorizontalCoordinates coordinates, GoingParams movement)
        {
            Coordinates = coordinates;
            Movement = movement;
        }

        public void Go()
        {
            Coordinates.Offset(Movement);
            Console.WriteLine("Иду");
        }
    }
}
