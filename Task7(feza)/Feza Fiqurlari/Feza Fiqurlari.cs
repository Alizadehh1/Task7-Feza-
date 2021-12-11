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
        public double height;
        public double width;
        public double length;





        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value<=0)
                {
                    throw new Exception("Duzgun Daxil edin!!");
                }
                radius = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                if (value<=0)
                {
                    throw new Exception("Duzgun Daxil edin!!");
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                if (value <= 0)
                {
                    throw new Exception("Duzgun Daxil edin!!");
                }
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                if (value <= 0)
                {
                    throw new Exception("Duzgun Daxil edin!!");
                }
            }
        }


        public double Soturacaq()
        {
            return Math.Round(Math.PI * (Math.Pow(radius, 2)),2);
            
        }
    }
}
