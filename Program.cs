using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            car automobil = new car();
            car automobil1 = new car("bmw", "325");


            Console.WriteLine(" Unesite zeljenu jacinu auta");
            automobil.jacina = int.Parse(Console.ReadLine());

           
           

            if (automobil.jacina == 2000)
            {
                Console.WriteLine(" Auto " + automobil.name + " " + automobil.model + " je brzo auto");
            }
            else if(automobil.jacina < 2000)
            {
                Console.WriteLine("Auto " + automobil.name + " " + automobil.model + " je slabo auto");
            }

            else
            {
                Console.WriteLine("Auto " + automobil.name + " " + automobil.model + " je veoma brzo auto");
            }
            Console.WriteLine();

            Console.WriteLine(" Unesite zeljenu jacinu vaseg drugog automobila");
            automobil1.jacina = int.Parse(Console.ReadLine());

            if (automobil1.jacina == 2000)
            {
                Console.WriteLine("Automobil" + automobil1.name + " " + automobil1.model + " je prosecno brzo auto");

            }
            else if(automobil1.jacina < 2000)
            {
                Console.WriteLine("Automobil" + automobil1.name + " " + automobil1.model + " je slabo auto");
            }
            else
            {
                Console.WriteLine("Automobil" + automobil1.name + " " + automobil1.model + " je veoma brz auto");
            }
            Console.ReadKey();
        }
    }
    
    class car
    {
        public string name;
        public string model;
        public string boja;
        public string vrata;
        public int jacina;

        public car()
        {
            name = "audi";
            model = "a4";
            boja = "crna";
            vrata = "5";
            jacina = 2600;


        }

        public car(string nm, string md)
        {
            name = "BMW";
            model = "325";
            boja = "bela";
            vrata = "4";
            jacina = 2500;
        }

        
    }
}
