using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение вида 0 = kx+b\nВведите значение k и b");
            double k =new double();
            double b = new double();
            Equation x = new Equation(Number(k), Number(b));
            x.Root();
            Console.ReadKey();
        }
        static double Number(double a)
        {
            try
            {
               a= Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("Неверный формат");
            }
            return a;
        }
    }
    struct Equation
    {

        public double K {get;set;}
        public double B { get; set; }
        
        public Equation(double k,double b)
        {
            
            K = k;
            B = b;
        }
        public void Root()
        {
            if (K == 0|| B==0 )
            {
                Console.WriteLine("Нет решений");
            }
            else
            {
                
                double x;
                Console.WriteLine("x = {0}",x = -B / K);;
            }
        }

    }


}
