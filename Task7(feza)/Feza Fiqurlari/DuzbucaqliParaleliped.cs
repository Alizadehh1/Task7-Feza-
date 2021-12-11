using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_feza_.Feza_Fiqurlari
{
    class DuzbucaqliParaleliped : Feza_Fiqurlari
    {
        public double width;
        public double lenght;

        public double Hecm()
        {
            return width * lenght * Height;
        }
        public double Stam()
        {
            return 2 * (width * lenght + width * Height + lenght * Height);
        }
    }
}
