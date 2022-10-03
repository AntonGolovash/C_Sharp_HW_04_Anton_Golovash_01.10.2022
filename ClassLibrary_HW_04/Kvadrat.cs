using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    public class Kvadrat : GeometricheskayaFigura
    {
        readonly double storona;
        public Kvadrat(double storona)
        {
            this.storona = storona;

        }
        public override double PerimetrFigury()
        {
            return storona * 4;
        }

        public override double PloshadFigury()
        {
            return Math.Pow(storona, 2);
        }
    }
}
