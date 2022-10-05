using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    public class Krug : GeometricheskayaFigura
    {
        int radius;
        public Krug(int radius)
        {
            this.radius = radius;
        }
        public override double PerimetrFigury()
        {
            return 2 * Math.PI * radius;
        }
        public override double PloshadFigury()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
