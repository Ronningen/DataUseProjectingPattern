using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OOP_DataUseProjecting.DataClasses;
using OOP_DataUseProjecting.DataUsingActionClasses;

namespace OOP_DataUseProjecting.Actors
{
    class Actor
    {
        public HorizontalCoordinates Coordinates { get; private set; }
        private GoingAction goer;
        private ShowingAction shower;

        public Actor()
        {
            Coordinates = new HorizontalCoordinates(0, 0);
            goer = new GoingAction(Coordinates);
            shower = new ShowingAction(Coordinates, new ShowingParams(Color.Black));
        }

        public void Go()
        {
            goer.Movement.xOffset = 1;
            goer.Movement.yOffset = 1;
            goer.Act();
        }

        public void Show()
        {
            shower.Act();
        }
    }
}
