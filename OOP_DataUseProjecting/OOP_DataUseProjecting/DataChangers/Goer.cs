using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DataUseProjecting
{
    class Goer : ICanGo
    {
        private Coordinates coordinates;
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }

        public Goer(Coordinates coordinates, int speedX, int speedY)
        {
            this.coordinates = coordinates;
            SpeedX = speedX;
            SpeedY = speedY;
        }

        public void Go()
        {
            Console.Write("Иду из точке (" + coordinates.X + "; " + coordinates.Y + ") ");
            coordinates.X += SpeedX;
            coordinates.Y += SpeedY;
            Console.WriteLine("в точку (" + coordinates.X + "; " + coordinates.Y + ")");
        }
    }
}
