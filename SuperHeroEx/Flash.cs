using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroEx
{
    class Flash : Human, IFlash
    {
        public int Voltage { get; private set; }
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != " ")
                    name= value;
            }
        }

        public Flash( int age) : base(age)
        {
            Name = "Flash Gordon";
            Voltage = 10000000;
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine($"Omg Flash is firing lightnings");
        }

        public void FireLightnings()
        {
            Console.WriteLine("Omg Flash is firing lightnings");
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] Name {Name} Voltage : {Voltage} Age {GetAge()}";
        }
    }
}
