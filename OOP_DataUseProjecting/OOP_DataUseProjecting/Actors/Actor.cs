using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace OOP_DataUseProjecting
{
    class Actor : ICanGo, ICanShow
    {
        private Coordinates coordinates;
        private Goer goer;
        private Shower shower;

        public Actor()
        {
            coordinates = new Coordinates(0, 0);
            goer = new Goer(coordinates, 1, 1);
            shower = new Shower(coordinates, Color.White);
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
