using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    public static class SostvnayaFigura
    {
        public static double PloshadSostavnoyFigury(List<GeometricheskayaFigura> figuras)
        {
            double ploshad = 0;
            foreach (var item in figuras)
            {
                ploshad += item.PloshadFigury();
            }
            return ploshad;
        }
    }
}
