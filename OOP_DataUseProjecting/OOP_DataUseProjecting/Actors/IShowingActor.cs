using System;
using System.Collections.Generic;
using System.Text;
using OOP_DataUseProjecting.DataUsingActionClasses;

namespace OOP_DataUseProjecting.Actors
{
    interface IShowingActor
    {
        ShowingAction Shower { get; set; }

        void Show();
    }
}
