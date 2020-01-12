using System;
using System.Collections.Generic;
using System.Text;
using OOP_DataUseProjecting.DataClasses;

namespace OOP_DataUseProjecting.DataUsingActionClasses
{
    class GoingAction : IDataUsingAction
    {
        private HorizontalCoordinates coordinates;
        public GoingParams Movement { get; set; }
        public Data[] UsingData
        {
            get
            {
                return new Data[] { coordinates, Movement };
            }
        }

        public GoingAction(HorizontalCoordinates coordinates) 
            : this(coordinates, new GoingParams(0, 0))
        { }

        public GoingAction(HorizontalCoordinates coordinates, GoingParams movement)
        {
            this.coordinates = coordinates;
            Movement = movement;
        }

        public void Act()
        {
            coordinates.Offset(Movement);
            Console.WriteLine("Шажок.");
        }
    }
}
