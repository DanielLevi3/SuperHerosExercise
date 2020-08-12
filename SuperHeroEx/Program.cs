using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash G = new Flash(36);
            GetMoreHeroData(G);
            ISuperHero[] giborim = new ISuperHero[3];
            giborim[0] = new SpiderMan(30, 18);
            giborim[1] = new SuperMan(25);
            giborim[2] = new Flash(24);
            foreach (ISuperHero i in giborim)
            {
                ActivateHero(i);
            }
            foreach (ISuperHero i in giborim)
            {
                IdentifyHero(i);
            }
            foreach (ISuperHero i in giborim)
            {
                GetMoreHeroData(i);
            }
            Console.WriteLine("============");
            CreateHero("SuperMan");
            CreateHero("sda");

        }
        static void ActivateHero(ISuperHero superHero)
        {
            if (superHero is SuperMan)
            {
                ISuperHero s = (SuperMan)superHero;
                s.ActivateSuperPowers();
            }
            else if (superHero is SpiderMan)
            {
                ISuperHero spider = (SpiderMan)superHero;
                spider.ActivateSuperPowers();
            }
            else
            {
                ISuperHero f = (Flash)superHero;
                f.ActivateSuperPowers();
            }
        }
        static void IdentifyHero(ISuperHero superHero)
        {
            if (superHero is SuperMan)
            {
                Console.WriteLine("Superman detected");
            }
            if (superHero is SpiderMan)
            {
                Console.WriteLine("Spiderman detected");
            }
            if (superHero is Flash)
            {
                Console.WriteLine("Flash detected");
            }
        }
         static void GetMoreHeroData(ISuperHero superhero)
        {
            Flash try_flash = superhero as Flash;
            SpiderMan try_spiderman = superhero as SpiderMan;
            SuperMan try_superMan = superhero as SuperMan;
            if (superhero == try_superMan)
            {
                if (try_superMan != null)
                {
                    Console.WriteLine(try_superMan.Name);
                    Console.WriteLine(try_superMan.GetAge());
                }
            }
            else if (superhero == try_spiderman)
            {
                if (try_spiderman != null)
                {
                    Console.WriteLine(try_spiderman.Name);
                    Console.WriteLine(try_spiderman.GetAge());
                    Console.WriteLine(try_spiderman.WebLeft);
                }
            }
            else
            {
                if (try_flash != null)
                {
                    Console.WriteLine(try_flash.Name);
                    Console.WriteLine(try_flash.Voltage);
                    Console.WriteLine(try_flash.GetAge());
                }
            }
        }
        public static void  CreateHero(string s)
        {
            if (s == "SuperMan")
            {
                SuperMan super = new SuperMan(18);
                Console.WriteLine(super);
            }
            else if (s == "SpiderMan")
            {
                SpiderMan spider = new SpiderMan(10, 25);
                Console.WriteLine(spider); 
            }
            else if(s== "Flash")
            {
                Flash flash = new Flash( 27);
                Console.WriteLine(flash);
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
  



