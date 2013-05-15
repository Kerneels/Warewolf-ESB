﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev2.DataList.Contract
{
    public class RecordsetNotFoundException : Exception
    {
        public RecordsetNotFoundException() : base()
        {
        }

        public RecordsetNotFoundException(string message) : base(message)
        {
        }

        public RecordsetNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
