using djurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djurar
{
    internal class Animals
    {
        public string _Name;
        public string _Sound;
        public string _Food;
        public string _Habitat;


        public Animals(string Name, string Sound, string Food, string Habitat)
        {
            this._Name = Name;
            this._Sound = Sound;
            this._Food = Food;
            this._Habitat = Habitat;
        }



        public void MakeSound()

        {

            Console.WriteLine($"A {_Name} {_Sound}");
        }
        public void GetFood()
        {

            Console.WriteLine(_Food);

        }
        public void GetHabitat()
        {
            Console.WriteLine(_Habitat);

        }


    }
}
