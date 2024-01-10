using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount;

        public Bicycle(int WheelCount)
        {
            _wheelCount = WheelCount;
        }

        public int WheelCount { get => _wheelCount; set => _wheelCount = value; }
    }
}
