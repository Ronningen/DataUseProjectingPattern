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
    }

    static partial class InterfacesExtension
    {
        public static void Go(this ICanGo actor)
        {
            actor.Coordinates.Offset(actor.Movement);
            Console.WriteLine("Иду");
        }
    }
}
