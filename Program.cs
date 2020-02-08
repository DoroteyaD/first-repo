using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zad
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            double vremevsek = 0;
            double vremevh = 0;
            double mvmil = 0;
            double mvkm = 0;
            vremevsek = h * 3600 + min * 60 + sec;
            Console.WriteLine("Vremeto v sekundi e: "+vremevsek);
            vremevh = sec / 3600 + min / 60 + h;
            Console.WriteLine("Vremeto v chasove e: "+vremevh);
            mvmil = m / 1609.344;
            Console.WriteLine("Metri v mili: " + mvmil );
            mvkm = m / 1000;
            Console.WriteLine("Metri v kilometri: " + mvkm);
            double mvsec = 0;
            double kmvh = 0;
            double milvh = 0;
            mvsec = m / vremevsek;
            kmvh = mvkm / vremevh;
            milvh = mvmil / vremevh;
            Console.WriteLine("m/s="+mvsec);
            Console.WriteLine("km/h="+kmvh);
            Console.WriteLine("mil/h=" + milvh); 

            
        }
    }
}
