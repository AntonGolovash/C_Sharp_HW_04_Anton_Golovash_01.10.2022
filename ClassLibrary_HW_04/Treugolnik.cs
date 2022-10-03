using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    public class Treugolnik : GeometricheskayaFigura
    {
        readonly double storona;
        public Treugolnik(double storona)
        {
            this.storona = storona;
        }
        public override double PerimetrFigury()
        {
            return storona * 3;
        }

        public override double PloshadFigury()
        {
            return Math.Sqrt(3)/4*Math.Pow(storona, 2);
        }
    }
}
