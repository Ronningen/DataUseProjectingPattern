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

        public Color Color { get; private set; }

        private Goer goer;
        private Shower shower;

        public Actor()
        {
            Coordinates = new HorizontalCoordinates(0, 0);
            Movement = new GoingParams(0, 0);
            Color = Color.Red;
            goer = new Goer(Coordinates, Movement);
            shower = new Shower(Coordinates, Color);
        }

        public void Go()
        {
            goer.Go();
        }

        public void Show()
        {
            shower.Show();
        }
    }
}
