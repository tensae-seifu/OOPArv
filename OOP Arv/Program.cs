using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Bark","long",160,200,4);

            puppy.GetLegs();
            puppy.GetSound();
            puppy.GetTail();
        }
    }
}
