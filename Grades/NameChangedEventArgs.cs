﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class NameChangedEventArgs : EventArgs
    {
        public String ExistingName { get; set; }
        public String NewName { get; set; }
    }
}
