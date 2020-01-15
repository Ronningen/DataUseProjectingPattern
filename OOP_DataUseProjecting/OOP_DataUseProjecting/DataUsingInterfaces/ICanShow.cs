using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using OOP_DataUseProjecting.DataClasses;

namespace OOP_DataUseProjecting.DataUsingInterfaces
{
    interface ICanShow
    {
        HorizontalCoordinates Coordinates { get; }
        Color Color  { get; }

        void Show();
    }

    class Shower : ICanShow
    {
        public HorizontalCoordinates Coordinates { get; set; }
        public Color Color { get; set;  }

        public Shower(HorizontalCoordinates coordinates, Color color)
        {
            Coordinates = coordinates;
            this.Color = color;
        }

        public void Show()
        {
            Console.Write("Рисую, вот цветом " + Color.Name + ".");
        }
    }
}
