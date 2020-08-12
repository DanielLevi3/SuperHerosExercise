using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroEx
{
    class SuperMan : Human, IFly
    {
        public int Speed { get; private set; }
        private string name;
        public SuperMan(int age) : base(age)
        {
            this.GetAge();
            Name = "Clark Kent";
            Speed = 1_000_000;
        }
        
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != " ")
                    name = value;
            }
        }

        public void ActivateSuperPowers()
        {
            Console.WriteLine($"Is it a airplan??,a bird?...No Its SuperMan flying");
        }

        public void Fly()
        {
            Console.WriteLine("Is it a airplan??,a bird?...No Its SuperMan");
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] Age: {GetAge()}, Speed :{Speed}"; 
        }
    }
}
