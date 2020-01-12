using System;
using System.Collections.Generic;
using System.Text;
using OOP_DataUseProjecting.DataClasses;

namespace OOP_DataUseProjecting.DataUsingActionClasses
{
    class ShowingAction : IDataUsingAction
    {
        private HorizontalCoordinates coordinates;
        public ShowingParams CurrentShowingParams { get; set; }
        
        public Data[] UsingData
        {
            get
            {
                return new Data[] { coordinates, CurrentShowingParams };
            }
        }

        public ShowingAction(HorizontalCoordinates coordinates, ShowingParams currentShowingParams)
        {
            this.coordinates = coordinates;
            CurrentShowingParams = currentShowingParams;
        }

        public void Act()
        {
            Console.WriteLine("Рисую, ыть.");
        }
    }
}
