using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Func<double, double> calcDelegate = Circumference;
            calcDelegate = calcDelegate + SqrCircle + VolBall;
            calcDelegate?.Invoke(radius);
            Console.ReadKey();
        }

        static double Circumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"Длина окружности радиусом R={radius}: D={circumference:f3}");
            return circumference;
        }
        static double SqrCircle(double radius)
        {
            double sqrCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга радиусом R={radius}: S={sqrCircle:f3}");
            return sqrCircle;
        }
        static double VolBall(double radius)
        {
            double volBall = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Объем шара радиусом R={radius}: V={volBall:f3}");
            return volBall;
        }

    }
}
