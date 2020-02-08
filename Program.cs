using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1._2
{
    class Program
    {
        static double Vremetovsekundi(double h, double min, double sec)
        {
            double vremevsek = h * 3600 + min * 60 + sec;
            return vremevsek;
        }
        static double vremetovchasove(double h, double min, double sec)
        {
            double vremevh = sec / 3600 + min / 60 + h;
            return vremevh;
        }
        static double MetrivMili(double m)

        { double mvmil = m / 1609.344;
            return mvmil;
        }
        static double MetrivKm(double m)

        {
            double mvkm = m / 1000;
            return mvkm;
        }


        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            //double vremevsek = 0;
            //double vremevh = 0;
            //double mvmil = 0;
            //double mvkm = 0;
           
            Console.WriteLine("Vremeto v sekundi e: " + Vremetovsekundi(h,min,sec));

            Console.WriteLine("Vremeto v chasove e: " + vremetovchasove(h, min, sec));

            Console.WriteLine("Metri v mili: " + MetrivMili(m));


            Console.WriteLine("Metri v kilometri: " + MetrivKm (m));
            //double mvsec = 0;
            //double kmvh = 0;
            //double milvh = 0;
            //mvsec = m / vremevsek;
            //kmvh = mvkm / vremevh;
            //milvh = mvmil / vremevh;
            //Console.WriteLine("m/s=" + mvsec);
            //Console.WriteLine("km/h=" + kmvh);
            //Console.WriteLine("mil/h=" + milvh);
        }
    }
    }

