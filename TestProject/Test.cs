﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public abstract class Test
    {
        public bool isRunning { get; set; }

        public abstract bool RunTests(string input);
    }
}
