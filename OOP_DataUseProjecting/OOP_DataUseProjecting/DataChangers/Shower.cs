using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace OOP_DataUseProjecting
{
    class Shower : ICanShow
    {
        private Coordinates coordinates;
        private Color color;

        public Shower(Coordinates coordinates, Color color)
        {
            this.coordinates = coordinates;
            this.color = color;
        }

        public void Show()
        {
            Console.Write("Рисую, вот цветом " + color.Name + " в точке (" + coordinates.X + "; " + coordinates.Y + "). ");
        }
    }
}
