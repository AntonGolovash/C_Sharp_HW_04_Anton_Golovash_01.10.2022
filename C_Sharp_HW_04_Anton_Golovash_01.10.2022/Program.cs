using ClassLibrary_HW_04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_04_Anton_Golovash_01._10._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Treugolnik treugolnik = new Treugolnik(5);
            treugolnik.PerimetrFigury();
            treugolnik.PloshadFigury();

            Kvadrat kvadrat = new Kvadrat(7);
            kvadrat.PerimetrFigury();
            kvadrat.PloshadFigury();


        }
    }
}
