using ClassLibrary_HW_04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_04_Anton_Golovash_01._10._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ellips ellips = new Ellips();
            ellips.PerimetrFigury();
            ellips.PloshadFigury();

            Krug krug = new Krug(11);
            krug.PerimetrFigury();
            krug.PloshadFigury();

            Kvadrat kvadrat = new Kvadrat(7);
            kvadrat.PerimetrFigury();
            kvadrat.PloshadFigury();

            Parallelogramm parallelogramm = new Parallelogramm(8, 12, 35);
            parallelogramm.PerimetrFigury();
            parallelogramm.PloshadFigury();

            Priamougolnik priamougolnik = new Priamougolnik(3, 5);
            priamougolnik.PerimetrFigury();
            priamougolnik.PloshadFigury();

            Romb romb = new Romb(4, 30);
            romb.PerimetrFigury();
            romb.PloshadFigury();

            Trapecia trapecia = new Trapecia();
            trapecia.PerimetrFigury();
            trapecia.PloshadFigury();

            Treugolnik treugolnik = new Treugolnik(5);
            treugolnik.PerimetrFigury();
            treugolnik.PloshadFigury();

            List<GeometricheskayaFigura> figuras = new List<GeometricheskayaFigura>
            { ellips, krug, kvadrat, parallelogramm, priamougolnik, romb, trapecia, treugolnik };

            Console.WriteLine($"Площадь составной фигуры = {SostvnayaFigura.PloshadSostavnoyFigury(figuras)}");
            Console.ReadKey();
        }
    }
}
