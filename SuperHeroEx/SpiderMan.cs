using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroEx
{
    class SpiderMan : Human, IClimb
    {
        private string name;
       public int WebLeft { get; private set; }
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
        public SpiderMan(int webleft,int age): base (age)
        {
            WebLeft = 30;
            this.WebLeft = webleft;
            Name = "Peter Parker";
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine("Only when my SpiderSuite on");
        }
        public void Climb()
        {
            Console.WriteLine("Look im walking on walls");
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] Age : {GetAge()} Name: {Name} WebLeft : {WebLeft}";
        }
    }
}
