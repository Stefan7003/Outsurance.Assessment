﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outsurance.Assessment.Domain
{
    public interface ICSVReader
    {
        string[] ReadAllLines(string path);
    }
}
