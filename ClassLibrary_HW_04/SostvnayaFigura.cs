using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_HW_04
{
    public static class SostvnayaFigura
    {
        static double PloshadSostavnoyFigury(GeometricheskayaFigura[] figuras)
        {
            double ploshad = 0;
            for (int i = 0; i < figuras.Length; i++)
            {
                ploshad += figuras[i].PloshadFigury();
            }
            return ploshad;
        }
    }
}
