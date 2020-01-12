using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DataUseProjecting.DataClasses
{
    class HorizontalCoordinates : Data
    {
        public float x, y;

        public HorizontalCoordinates(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Offset(GoingParams movement)
        {
            x += movement.xOffset;
            y += movement.yOffset;
        }
    }
}
