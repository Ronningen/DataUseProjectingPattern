using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOP_DataUseProjecting.DataClasses
{
    class ShowingParams : Data
    {
        Color colour;

        public ShowingParams(Color colour)
        {
            this.colour = colour;
        }
    }
}
