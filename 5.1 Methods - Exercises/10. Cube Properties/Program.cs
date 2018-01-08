using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double site = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine("{0:F2}",FaceDiagonalsCube(site));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:F2}",SpaceDiagonalsCube(site));
            }
            else if (parameter == "volume")
            {
                Console.WriteLine("{0:F2}",VolumeCube(site));
            }
            else
            {
                Console.WriteLine("{0:F2}",SurfaceAreaCube(site));
            }
        }

        static double FaceDiagonalsCube(double site)
        {
            double result = Math.Sqrt(2 * (site * site));
            return result;
        }

        static double SpaceDiagonalsCube(double site)
        {
            double result = Math.Sqrt(3 * (site * site));
            return result;
        }

        static double VolumeCube(double site)
        {
            double result = Math.Pow(site, 3);
            return result;
        }

        static double SurfaceAreaCube(double site)
        {
            double result = 6 * (site * site);
            return result;
        }
    }
}
