﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Diagnos
    {
        public int Code;
        public string Name;
        public Diagnos(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
