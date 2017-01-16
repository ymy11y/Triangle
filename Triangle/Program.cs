using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {/*
                Console.WriteLine("please input first side length:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("please input second side length:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("please input third side lenght:");
                double c = Convert.ToDouble(Console.ReadLine());

                Triangle t = new Triangle(a, b, c);*/
                Triangle t = new Triangle('p',3, 2);
                               
                Console.WriteLine(t.ToString());
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            
        }
    }
}
