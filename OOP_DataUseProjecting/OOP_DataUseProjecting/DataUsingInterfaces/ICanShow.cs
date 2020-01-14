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
        Color color  { get; }
    }

    static partial class InterfacesExtension
    {
        public static void Show(this ICanShow actor)
        {
            Console.Write("Рисую, вот цветом " + actor.color.Name + ".");
        }
    }
}
