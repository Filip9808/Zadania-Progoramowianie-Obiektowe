using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace HomeWork1
{
   class Koło
    {
        private double promień, środekX, środekY;


        public Koło(double r = 0.0, double x =0.0,double y=0.0)
        {
            this.promień = r;
            this.środekX = x;
            this.środekY = y;
        }

        public double Środek()
        {
            return 
        }
        public double Pole()
        {
            return Math.Round(Math.PI*Math.Pow(promień,2),2);
        }
        public double Obwód()
        {
            return Math.Round(2*Math.PI *promień,2);
        }

        public void daneWejściowe()
        {
            Console.Write("Podaj promień koła: ");
            promień = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współrzędną x środka koła: ");
            środekX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współrzędną y środka koła: ");
            środekY = Convert.ToDouble(Console.ReadLine());

        }

        public void daneWyjściowe()
        {
            Console.WriteLine("PI= " + Math.Round(Math.PI,2));
            Console.WriteLine("Współrzędne środka koła= " + this.Środek());
            Console.WriteLine("Pole koła= " + this.Pole());
            Console.WriteLine("Obwód koła= " + this.Obwód());

        }

        Boolean czyWKole(double x, double y)
        {
            bool check = Math.Pow((x - 0), promień) + Math.Pow((y - 0), promień) <= Math.Pow(promień, promień);
            Console.WriteLine("Point inside? {0}", check);

        }

    }
}
