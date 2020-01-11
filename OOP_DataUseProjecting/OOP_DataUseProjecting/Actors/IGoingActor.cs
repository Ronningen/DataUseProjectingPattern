using System;
using System.Collections.Generic;
using System.Text;
using OOP_DataUseProjecting.DataUsingActionClasses;

namespace OOP_DataUseProjecting.Actors
{
    interface IGoingActor
    {
        GoingAction Goer { get; set; }

        void Go();
    }
}
