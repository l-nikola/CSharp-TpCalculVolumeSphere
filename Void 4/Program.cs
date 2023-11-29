using System;

namespace Void_4
{
    class Program
    {
        public static double sphere(double R)
        {
            double V;
            V = (double)4 / 3 * Math.PI * Math.Pow(R, 3);

            return V;
        }
        static void Main(string[] args)
        {
            double R, V;

            Console.WriteLine("Quel est le rayon de votre sphere ?");
            R = Double.Parse(Console.ReadLine());

            V = sphere(R);

            Console.WriteLine("Le volume de votre sphere est de " + V);
            Console.ReadLine();
        }
    }
}
