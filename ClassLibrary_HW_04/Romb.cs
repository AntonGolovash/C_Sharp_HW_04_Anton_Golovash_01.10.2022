using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    internal class Romb : GeometricheskayaFigura
    {
        readonly double storona;
        readonly int ugol;

        public Romb(double storona, int ugol)
        {
            this.storona = storona;
            this.ugol = ugol;
        }
        public override double PerimetrFigury()
        {
            return storona * 4;
        }

        public override double PloshadFigury()
        {
            return Math.Pow(storona, 2) * Math.Sin(ugol);
        }
    }
}
