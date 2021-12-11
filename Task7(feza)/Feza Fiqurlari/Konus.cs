using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_feza_.Feza_Fiqurlari
{
    class Konus : Feza_Fiqurlari
    {
        public double Hecm()
        {
            return Math.Round(Math.PI * (Math.Pow(radius, 2)) * (Height / 3),2);
        }
    }
}
