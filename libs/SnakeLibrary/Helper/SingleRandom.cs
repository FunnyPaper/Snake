using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Helper
{
    public class SingleRandom : Random
    {
        public static Random Access { get; }

        static SingleRandom()
        {
            Access = new Random();
        }
    }
}
