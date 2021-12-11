using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_feza_.Feza_Fiqurlari
{
    class Silindr : Feza_Fiqurlari
    {
        public double Hecm()
        {
            return Pi * (Math.Pow(radius, 2)) * Height;
        }
        public double Stam()
        {
            return 2 * (Pi * (Math.Pow(radius, 2))) + 2 * Pi * radius * Height;
        }
    }
}
