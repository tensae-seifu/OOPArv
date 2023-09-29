using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djurar
{
    internal class Dog : Animals
    {


       public string _Attitude;

        public Dog(string Name, string Attitude)
            : base(Name, "Barks", "Omnivor", "indoors")
        {
            _Attitude = Attitude;
        }

        public void Attit()
        {
            Console.WriteLine($"Is very {_Attitude}");
        }
    }

    class Chiwawa : Dog

    {
        public string _Size;

        public Chiwawa(string Name, string Size) : base(Name, "Guffy")
        {
            this._Size = Size;
        }

        public void GetSize()

        {
            Console.WriteLine($"A {_Name} is very {_Size} in size");
        }


        class Bulldog : Dog

        {
            public string _Strength;

            public Bulldog(string Name, string Strength) : base(Name, "Strong")
            {
                this._Strength = Strength;
            }

            public void GetStrength()

            {
                Console.WriteLine($"A {_Name} is very {_Strength} in size");
            }
        }
    }
}