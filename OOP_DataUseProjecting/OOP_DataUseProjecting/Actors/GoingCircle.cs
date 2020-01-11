using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OOP_DataUseProjecting.DataClasses;
using OOP_DataUseProjecting.DataUsingActionClasses;

namespace OOP_DataUseProjecting.Actors
{
    class GoingCircle : IGoingActor, IShowingActor
    {
        public readonly HorizontalCoordinates coordinates;
        public GoingAction Goer { get; set; }
        public ShowingAction Shower { get; set; }

        public GoingCircle()
        {
            coordinates = new HorizontalCoordinates(0, 0);
            Goer = new GoingAction(coordinates);
            Shower = new ShowingAction(coordinates, new ShowingParams(Color.Black));
        }

        public void Go()
        {
            Goer.Movement.xOffset = 1;
            Goer.Movement.yOffset = 1;
            Goer.Act();
        }

        public void Show()
        {
            Shower.Act();
        }
    }
}
