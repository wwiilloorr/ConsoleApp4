using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void workC()
        {
            double Celsij = 0;
            double Farenhejt = 0;
            double kelvin = 0;

            Console.WriteLine("You just choosed C");
            Console.Write("Enter Celsiun cost: ");
            Celsij = Convert.ToDouble(Console.ReadLine());
            Console.Write("At what you want to convert Celsium?(1 - Farenheit;2 - Kelvin):  ");
            int chooseF = Convert.ToInt32(Console.ReadLine());
            if (chooseF == 1)
            {
                Farenhejt = Celsij * (9 / 5) + 32;
                Console.WriteLine("From: " + Celsij + "C you got: " + Farenhejt + "F");
            }
            else if(chooseF == 2)
            {
                kelvin = Celsij + 273.15;
                Console.WriteLine("From: " + Celsij + "C you got: " + kelvin + "K");
            }
            else
            {
                showError();
            }
        }
        public static void workF()
        {
            double Celsij = 0;
            double Farenhejt = 0;
            double kelvin = 0;

            Console.WriteLine("You just choosed F");
            Console.Write("Enter the number of Farenheit:  ");
            Farenhejt = Convert.ToDouble(Console.ReadLine());
            Console.Write("At what you want to convert Farenheit?(1 - Celsium;2 - Kelvin):  ");
            int chooseS = Convert.ToInt32(Console.ReadLine());  

            if(chooseS == 1)
            {
                Celsij = (Farenhejt - 32) * (9 / 5);
                Console.WriteLine("From: " + Farenhejt + "F you got: " + Celsij + "C");
            }
            else if (chooseS == 2)
            {
                kelvin = (Farenhejt - 32) * (9 / 5) + 273.15;
                Console.WriteLine("From: " + Farenhejt + "F you got: " + kelvin + "K");
            }
        }
        public static void workK()
        {
            double Celsij = 0;
            double Farenhejt = 0;
            double kelvin = 0;

            Console.WriteLine("You just choosed Kelvin!");
            Console.Write("Enter the number of kelvin:  ");
            kelvin = Convert.ToDouble(Console.ReadLine());
            Console.Write("At what you want to convert Kelvin?(1 - Celsium;2 - Farenheit):  ");
            int chooseT = Convert.ToInt32(Console.ReadLine());          
            
            if(chooseT == 1)
            {
                Celsij = kelvin - 273.15;
            }
            else if(chooseT == 2)
            {
                Farenhejt = (kelvin - 273.15) * (9 / 5) + 32;
            }
            else
            {
                showError();
            }
            

                    



        }
        public static void mainWork()
        {
            int choose = 0;

            Console.Write("What you want to convert 1 - C; 2 - F;3 - K: ");
            choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                workC();
            }
            else if (choose == 2)
            {
                workF();
            }
            else if (choose == 3)
            {
                workK();
            }
            else
            {
                showError();
            }
        }

        
        public static void showError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!!!!!!!!!!");
            Console.ResetColor();
        }
  
        static void Main(string[] args)
        {
            while(true)
            {
                mainWork();
            }
        }
    }
}
