using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_feza_.Feza_Fiqurlari
{
    class Feza_Fiqurlari
    {
        public double radius;
        public double Height;
        public double Pi = 3.14;

        public double Soturacaq()
        {
            return Pi * (Math.Pow(radius, 2));
        }
    }
}
