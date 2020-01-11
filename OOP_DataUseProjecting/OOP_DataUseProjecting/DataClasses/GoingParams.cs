using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DataUseProjecting.DataClasses
{
    class GoingParams : Data
    {
        public float xOffset, yOffset;

        public GoingParams(float xOffset, float yOffset)
        {
            this.xOffset = xOffset;
            this.yOffset = yOffset;
        }
    }
}
