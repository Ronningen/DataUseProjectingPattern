using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DataUseProjecting.DataUsingActionClasses
{
    interface IDataUsingAction
    {
        DataClasses.Data[] UsingData { get; }
        void Act();
    }
}
