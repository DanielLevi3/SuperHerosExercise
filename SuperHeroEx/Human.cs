using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroEx
{
    abstract class Human
    {
        public abstract string Name{ get; set;} 
        private readonly int _age;
        public Human( int age)
        {
            this._age = age;
        }
        public int GetAge()
        {
            return _age;
        }
        public override string ToString()
        {
            return $" Age : {this._age}";
        }
    }
}
