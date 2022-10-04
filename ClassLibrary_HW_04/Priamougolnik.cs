using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    internal class Priamougolnik : GeometricheskayaFigura
    {
        readonly double storona1;
        readonly double storona2;
        public Priamougolnik(double storona1, double storona2)
        {
            this.storona1 = storona1;
            this.storona2 = storona2;
        }
        public override double PerimetrFigury()
        {
            return (storona1 + storona2) * 2;
        }

        public override double PloshadFigury()
        {
            return storona1 * storona2;
        }
    }
}
