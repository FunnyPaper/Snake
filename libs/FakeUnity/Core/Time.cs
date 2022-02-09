using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeUnity.Core
{
    public static class Time
    { 
        /// <summary>
        /// Czas mierzony pomiędzy klatkami klasy GameLoop
        /// </summary>
        public static double DeltaTime { get; internal set; }
    }
}
