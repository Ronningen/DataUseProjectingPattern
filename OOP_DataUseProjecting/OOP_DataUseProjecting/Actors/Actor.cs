using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using OOP_DataUseProjecting.DataClasses;
using OOP_DataUseProjecting.DataUsingInterfaces;

namespace OOP_DataUseProjecting.Actors
{
    class Actor : ICanGo, ICanShow
    {
        public HorizontalCoordinates Coordinates { get; private set; }

        public GoingParams Movement { get; private set; }

        public ShowingParams ShowingSettings { get; private set; }

        public Actor()
        {
            Coordinates = new HorizontalCoordinates(0, 0);
            Movement = new GoingParams(0, 0);
            ShowingSettings = new ShowingParams(Color.Red);
        }
    }
}
