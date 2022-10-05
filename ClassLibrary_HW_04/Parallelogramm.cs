using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    public class Parallelogramm : GeometricheskayaFigura
    {
        readonly double storona1;
        readonly double storona2;
        readonly int ugol;
        public Parallelogramm(double storona1, double storona2, int ugol)
        {
            this.storona1 = storona1;
            this.storona2 = storona2;
            this.ugol = ugol;
        }
        public override double PerimetrFigury()
        {
            return (storona1 + storona2) * 2;
        }

        public override double PloshadFigury()
        {
            return storona1 * storona2 * Math.Sin(ugol);
        }
    }
}
