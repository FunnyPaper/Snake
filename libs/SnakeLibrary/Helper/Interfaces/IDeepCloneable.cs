﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Helper.Interfaces
{
    public interface IDeepCloneable<T>
    {
        T DeepClone();
    }
}
